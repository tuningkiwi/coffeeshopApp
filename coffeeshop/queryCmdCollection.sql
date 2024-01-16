/*
select a.Id,Name,phone,grade,kor,eng from person a inner join student b on a.id=b.id;
*/


CREATE TABLE [dbo].[completed_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
	[menu_id]       INT NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [quantity] INT NULL,
    
);

CREATE TABLE [dbo].[current_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
    [menu_id]	INT NULL,
    [menu_name]       NVARCHAR (30) NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [size]            NCHAR (10)    NULL,
    [quantity] INT NULL,
    
);

CREATE TABLE [dbo].[item_price] (
	[menu_id] INT NULL,
    [menu_name] NVARCHAR (30) NULL,
    [size]      NCHAR (10)    NULL,
    [price]     INT           NULL
);

CREATE TABLE [dbo].[waiting_order_list] (
    [order_id]        INT           NULL,
    [order_detail_id] INT           NULL,
    [take_out_in]     NCHAR (10)    NULL,
    [menu_id] INT NULL,
    [menu_name]       NVARCHAR (30) NULL,
    [hot_cold]        NCHAR (10)    NULL,
    [size]            NCHAR (10)    NULL,
    [quantity] INT NULL
    
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
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (11, N'blueberry_yogurt', N'small', 5500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (12, N'vanila_latte', N'small', 5500)
INSERT INTO [dbo].[item_price] ([menu_id], [menu_name], [size], [price]) VALUES (13, N'vanila_latte', N'large', 6000)





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


/*주문 총 잔수 금액 */
select sum(quantity) as total_count from current_order_list


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

/* 주문 대기번호 order_id 출력 */
select TOP 1 order_id from current_order_list


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

insert into waiting_order_list ([order_id], [order_detail_id], [take_out_in],[menu_id], [menu_name], [hot_cold],[size],[quantity]) select order_id, order_detail_id, take_out_in, menu_id, menu_name, hot_cold, quantity from current_order_list;

delete from current_order_list;


-------------
/*item_price 제외하고 삭제 */

delete from completed_order_list;
delete from current_order_list;
delete from waiting_order_list;



/***************
   관리자모드 
****************/

/*관리자 모드에서, Waiting_order_list select, 완료된 주문항목 delete 및 completed_order_list로 이동 */
/*장바구니 처리랑 같음 )





            ////ROW, COLUMN 크기 자동 조정 
            //// Resize the master DataGridView columns to fit the newly loaded data.
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoResizeRows();
            //// Configure the details DataGridView so that its columns automatically
            //// adjust their widths when the data changes.
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView1.AutoSizeRowsMode =DataGridViewAutoSizeRowsMode.AllCells;

            //사용자 조정, 자동 조정 close 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns[2].Width = 200;

            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            //    dataGridView1.Columns[i].ReadOnly = true;
            //    dataGridView1.Columns[i].Width = 200;
            //}

            //dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
