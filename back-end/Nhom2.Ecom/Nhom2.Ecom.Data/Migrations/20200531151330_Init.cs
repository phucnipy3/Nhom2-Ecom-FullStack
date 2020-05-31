using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom2.Ecom.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    CreateBy = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    PromotionPrice = table.Column<decimal>(nullable: true),
                    CreateBy = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "PromotionCode",
                columns: table => new
                {
                    PromotionCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Infomation = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionCode", x => x.PromotionCodeID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Infomation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Permission = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDetail",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDetail", x => new { x.ProductID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_CategoryDetail_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CategoryDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    ProductImageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.ProductImageID);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    BlogID = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => new { x.BlogID, x.UserID });
                    table.ForeignKey(
                        name: "FK_BlogComment_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "BlogID");
                    table.ForeignKey(
                        name: "FK_BlogComment_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    CustomerAddressID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.CustomerAddressID);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Users_CustomerAddressID",
                        column: x => x.CustomerAddressID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID");
                });

            migrationBuilder.CreateTable(
                name: "ProductComment",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ParentID = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComment", x => new { x.ProductID, x.UserID });
                    table.ForeignKey(
                        name: "FK_ProductComment_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_ProductComment_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "ProductRate",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    RatePoint = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRate", x => new { x.ProductID, x.UserID });
                    table.ForeignKey(
                        name: "FK_ProductRate_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                    table.ForeignKey(
                        name: "FK_ProductRate_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    Transport = table.Column<string>(nullable: true),
                    Payment = table.Column<string>(nullable: true),
                    PromotionCodeID = table.Column<int>(nullable: true),
                    CustomerAddressID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_CustomerAddress_CustomerAddressID",
                        column: x => x.CustomerAddressID,
                        principalTable: "CustomerAddress",
                        principalColumn: "CustomerAddressID");
                    table.ForeignKey(
                        name: "FK_Order_PromotionCode_PromotionCodeID",
                        column: x => x.PromotionCodeID,
                        principalTable: "PromotionCode",
                        principalColumn: "PromotionCodeID");
                    table.ForeignKey(
                        name: "FK_Order_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.ProductID, x.OrderID });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "OrderTracking",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    CompleteAt = table.Column<DateTime>(nullable: true),
                    Information = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTracking", x => new { x.OrderID, x.StatusID });
                    table.ForeignKey(
                        name: "FK_OrderTracking_Order_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_OrderTracking_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_UserID",
                table: "BlogComment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetail_CategoryID",
                table: "CategoryDetail",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_ProvinceID",
                table: "CustomerAddress",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerAddressID",
                table: "Order",
                column: "CustomerAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PromotionCodeID",
                table: "Order",
                column: "PromotionCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTracking_StatusID",
                table: "OrderTracking",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_UserID",
                table: "ProductComment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductID",
                table: "ProductImage",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRate_UserID",
                table: "ProductRate",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComment");

            migrationBuilder.DropTable(
                name: "CategoryDetail");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "OrderTracking");

            migrationBuilder.DropTable(
                name: "ProductComment");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductRate");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "PromotionCode");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
