/*
select a.Id,Name,phone,grade,kor,eng from person a inner join student b on a.id=b.id;
*/


CREATE TABLE [dbo].[completed_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
	[menu_id]       INT NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [quantity]           INT           NULL,
    [payment_sign]    IMAGE         NULL
);

CREATE TABLE [dbo].[current_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
    [menu_id]	INT NULL,
    [menu_name]       NVARCHAR (30) NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [size]            NCHAR (10)    NULL,
    [quantity]           INT           NULL,
    [payment_sign]    IMAGE         NULL
);

CREATE TABLE [dbo].[item_price] (
	[menu_id] INT NULL,
    [menu_name] NVARCHAR (30) NULL,
    [size]      NCHAR (10)    NULL,
    [price]     INT           NULL
);


/*메뉴id별 가격 데이터 */
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (1, N'americano', N'small', 4500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (2, N'americano', N'large', 5000)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (3, N'caffe_latte', N'small', 5000)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (4, N'caffe_latte', N'large', 5500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (5, N'royalmilktea', N'small', 5500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (6, N'royalmilktea', N'large', 6000)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (7, N'strawberry_latte', N'small', 6000)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (8, N'strawberry_latte', N'large', 6500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (9, N'blueberry_yogurt', N'small', 5500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (10, N'blueberry_yogurt', N'large', 6000)



CREATE TABLE [dbo].[waiting_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
	[menu_id]       INT NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [quantity]           INT           NULL,
    [payment_sign]    IMAGE         NULL
);

/*주문자가 주문 세부사항을 선택완료 할 때마다 Current_order_list에 insert*/
/*데이터 삽입 current_order_list*/
INSERT INTO [dbo].[current_order_list] 
([order_id], [order_detail_id], [take_out_in], [menu_name],[hot_cold],[size],[quantity]) 
VALUES (1000,1,N'OUT',N'americano',N'cold',N'small',3)
INSERT INTO [dbo].[current_order_list] 
([order_id], [order_detail_id], [take_out_in], [menu_name],[hot_cold],[size],[quantity]) 
VALUES (1000,2,N'OUT',N'royalmilktea',N'hot',N'large',1)
INSERT INTO [dbo].[current_order_list]
([order_id], [order_detail_id], [take_out_in], [menu_name],[hot_cold],[size],[quantity]) 
VALUES (1001,3,N'IN',N'caffe_latte',N'hot',N'large',2)
INSERT INTO [dbo].[current_order_list] 
([order_id], [order_detail_id], [take_out_in], [menu_name],[hot_cold],[size],[quantity]) 
VALUES (1001,4,N'IN',N'strawberry_latte',N'hot',N'small',10)

/*메뉴 선택창 하단에 Current_order_list에 select */
select menu_name, hot_cold, size, quantity from current_order_list 

/*******장바구니 주문 리스트(최종 업데이트): 주문 내역 select, 수량 update, 항목 delete******/

/*주문내역 SHOW */
select menu_name, hot_cold, size, quantity from current_order_list 
select * from item_price

select cur.menu_name, cur.hot_cold, cur.size, cur.quantity, it.price, it.price*cur.quantity as total from current_order_list cur INNER JOIN item_price it
on cur.menu_name = it.menu_name and cur.size = it.size 

/*주문 합계 금액 */
select sum(it.price*cur.quantity) as total_price from current_order_list cur INNER JOIN item_price it
on cur.menu_name = it.menu_name and cur.size = it.size 

/*선택 항목 수량 UPDATE*/
update current_order_list set quantity=7 where order_detail_id=3
select * from current_order_list

/*선택 주문 항목 DELETE*/
delete from current_order_list where order_detail_id=3
select * from current_order_list

/* 메뉴ID 부여: current_order_list랑 item_price inner join   */
select * from current_order_list 
select * from item_price

/*결제창 주문 총액 보여주기: sum */
select sum(it.price*cur.quantity) as total_price from current_order_list cur INNER JOIN item_price it
on cur.menu_name = it.menu_name and cur.size = it.size 

/******결제가 완료되면, menu_id 업데이트와 현재 주문목록이 확정되어 처리대기중인 주문리스트로 복사됨  */
/*menu_id 업데이트 */
select * from item_price 
update current_order_list set menu_id=it.menu_id
    from current_order_list cur INNER JOIN  item_price it 
    on cur.menu_name=it.menu_name and cur.size=it.size;
select * from current_order_list; 

/*Current_order_list >>copy>>>Waiting_order_list  이후 current_order_list clear*/
insert into waiting_order_list ([order_id], [order_detail_id], [take_out_in],[menu_id], [hot_cold],[quantity])
    select order_id, order_detail_id, take_out_in, menu_id, hot_cold, quantity from current_order_list;

delete from current_order_list;


/***************
   관리자모드 
****************/

/*관리자 모드에서, Waiting_order_list select, 완료된 주문항목 delete 및 completed_order_list로 이동 */
/*장바구니 처리랑 같음 )




