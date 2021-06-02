using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class fgfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminPays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    TypePay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_GalleryProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_GalleryProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ImageGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGallery = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ImageGalleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Adress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(nullable: false),
                    Post = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    FirstAddress = table.Column<string>(nullable: true),
                    SecondAddress = table.Column<string>(nullable: true),
                    LocationAd = table.Column<string>(nullable: true),
                    Tel1Ad = table.Column<string>(nullable: true),
                    Tel2Ad = table.Column<string>(nullable: true),
                    Officetel1Ad = table.Column<string>(nullable: true),
                    Officetel2Ad = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Advertisings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_creator = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Title_Pro = table.Column<string>(nullable: true),
                    Discreption_Pro = table.Column<string>(nullable: true),
                    Type_pro = table.Column<string>(nullable: true),
                    Type_Transaction = table.Column<string>(nullable: true),
                    Main_Price_Auction = table.Column<string>(nullable: true),
                    Auction_Time = table.Column<string>(nullable: true),
                    Auction_Start_Time = table.Column<string>(nullable: true),
                    Main_Price = table.Column<string>(nullable: true),
                    PriceB = table.Column<int>(nullable: false),
                    Pricek = table.Column<int>(nullable: false),
                    PricekC = table.Column<int>(nullable: false),
                    Discount_Price = table.Column<string>(nullable: true),
                    Online_Exchange = table.Column<string>(nullable: true),
                    Take_Discount = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    TimeReturn = table.Column<DateTime>(nullable: false),
                    WhyReturn = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Special = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    FatherIdCat = table.Column<string>(nullable: true),
                    Father = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Advertisings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Agencie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageAg = table.Column<string>(nullable: true),
                    NameAg = table.Column<string>(nullable: true),
                    NamePersenAg = table.Column<string>(nullable: true),
                    TelAg = table.Column<string>(nullable: true),
                    OfficetelAg = table.Column<string>(nullable: true),
                    LocationAg = table.Column<string>(nullable: true),
                    DescreptionAg = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Agencie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Baner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlid = table.Column<string>(nullable: true),
                    CategoryIdSlid = table.Column<int>(nullable: false),
                    CategoryProductIdSlid = table.Column<int>(nullable: false),
                    TypeSlid = table.Column<string>(nullable: true),
                    ImageMainSlid = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Baner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleBLo = table.Column<string>(nullable: true),
                    IdCtegoryBlo = table.Column<int>(nullable: false),
                    SummaryBlo = table.Column<string>(nullable: true),
                    ImageMainBlo = table.Column<string>(nullable: true),
                    FullTextBlo = table.Column<string>(nullable: true),
                    KeywordsBlo = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCat = table.Column<string>(nullable: true),
                    FatherIdCat = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<string>(nullable: true),
                    Resever_Id = table.Column<string>(nullable: true),
                    Send_Id = table.Column<string>(nullable: true),
                    blog_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateComment = table.Column<DateTime>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Experts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEx = table.Column<string>(nullable: true),
                    ImageEx = table.Column<string>(nullable: true),
                    TelEx = table.Column<string>(nullable: true),
                    OfficeTelEx = table.Column<string>(nullable: true),
                    LocationEx = table.Column<string>(nullable: true),
                    AboutEx = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Factors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Order = table.Column<int>(nullable: false),
                    Id_creator = table.Column<int>(nullable: false),
                    Id_Factro = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    product_Name = table.Column<string>(nullable: true),
                    Date_Order = table.Column<DateTime>(nullable: false),
                    Product_Count = table.Column<int>(nullable: false),
                    product_Price = table.Column<int>(nullable: false),
                    Total_sum = table.Column<int>(nullable: false),
                    StatusA = table.Column<string>(nullable: true),
                    StatusM = table.Column<string>(nullable: true),
                    Type_Transaction = table.Column<string>(nullable: true),
                    TellBuy = table.Column<string>(nullable: true),
                    TellSel = table.Column<string>(nullable: true),
                    IdUser = table.Column<int>(nullable: false),
                    Post = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    FirstAddress = table.Column<string>(nullable: true),
                    PriceB = table.Column<string>(nullable: true),
                    PriceK = table.Column<string>(nullable: true),
                    NameBuy = table.Column<string>(nullable: true),
                    NameSel = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Pay = table.Column<string>(nullable: true),
                    Send_Sales_Code = table.Column<string>(nullable: true),
                    Send_Order_Code = table.Column<string>(nullable: true),
                    Send_Admin_Code = table.Column<string>(nullable: true),
                    Why_Return_Admin_Bazrasi = table.Column<string>(nullable: true),
                    Why_Return_Request = table.Column<string>(nullable: true),
                    ImageReturn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Factors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Factors2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrder = table.Column<int>(nullable: false),
                    IdClient = table.Column<int>(nullable: false),
                    IdSeller = table.Column<int>(nullable: false),
                    IdKala = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    prices = table.Column<int>(nullable: false),
                    Date = table.Column<int>(nullable: false),
                    Address = table.Column<int>(nullable: false),
                    Ordertype = table.Column<int>(nullable: false),
                    Inspection = table.Column<int>(nullable: false),
                    Orderstatus = table.Column<int>(nullable: false),
                    Reference = table.Column<int>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Factors2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Financial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameFi = table.Column<string>(nullable: true),
                    TelFi = table.Column<string>(nullable: true),
                    RemovalFi = table.Column<string>(nullable: true),
                    DepositFi = table.Column<string>(nullable: true),
                    DateFi = table.Column<DateTime>(nullable: false),
                    StateFi = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Financial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleGal = table.Column<string>(nullable: true),
                    pathImage = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Logo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleLogo = table.Column<string>(nullable: true),
                    ImageLogo = table.Column<string>(nullable: true),
                    FavIcon = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Logo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderMess = table.Column<string>(nullable: true),
                    ResiverMess = table.Column<string>(nullable: true),
                    DateMess = table.Column<DateTime>(nullable: false),
                    SubjectMess = table.Column<string>(nullable: true),
                    TextMess = table.Column<string>(nullable: true),
                    StateMess = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    pathfile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MyFavorites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKala = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MyFavorites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_user = table.Column<int>(nullable: false),
                    Date_Order = table.Column<DateTime>(nullable: false),
                    Pay = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Originality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProductOri = table.Column<int>(nullable: false),
                    NumberProductOri = table.Column<string>(nullable: true),
                    DateCreateOri = table.Column<DateTime>(nullable: false),
                    HologramCodeOri = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Originality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Pays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(nullable: true),
                    NameFamily = table.Column<string>(nullable: true),
                    Pay = table.Column<int>(nullable: false),
                    Harvest = table.Column<int>(nullable: false),
                    Paytime = table.Column<DateTime>(nullable: false),
                    havesttime = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    iduser = table.Column<int>(nullable: false),
                    Id_Factro = table.Column<int>(nullable: false),
                    StatusP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Type = table.Column<string>(nullable: true),
                    Min = table.Column<string>(nullable: true),
                    Max = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Price", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleProductPro = table.Column<string>(nullable: true),
                    ImageMainPro = table.Column<string>(nullable: true),
                    CategoryIdPro = table.Column<string>(nullable: true),
                    PricePro = table.Column<string>(nullable: true),
                    OfferPro = table.Column<string>(nullable: true),
                    SizePro = table.Column<string>(nullable: true),
                    ColorPro = table.Column<string>(nullable: true),
                    BrandPro = table.Column<string>(nullable: true),
                    TypeCarPro = table.Column<string>(nullable: true),
                    MaterialPro = table.Column<string>(nullable: true),
                    TotalPro = table.Column<string>(nullable: true),
                    DescreptionPro = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Richats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptChat = table.Column<string>(nullable: true),
                    zarinpal = table.Column<string>(nullable: true),
                    enemad = table.Column<string>(nullable: true),
                    sms = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true),
                    paternsms = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Richats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SendNumberCodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SendNumberCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlid = table.Column<string>(nullable: true),
                    CategoryIdSlid = table.Column<int>(nullable: false),
                    CategoryProductIdSlid = table.Column<int>(nullable: false),
                    TypeSlid = table.Column<string>(nullable: true),
                    ImageMainSlid = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    linkslaid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SocialNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instagram = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<string>(nullable: true),
                    Aparat = table.Column<string>(nullable: true),
                    Youtube = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SocialNetwork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Teaser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTeaser = table.Column<string>(nullable: true),
                    CategoryIdTeaser = table.Column<string>(nullable: true),
                    VideoPathTeaser = table.Column<string>(nullable: true),
                    LinkVideoTeaser = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Teaser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameUs = table.Column<string>(nullable: true),
                    EmailUS = table.Column<string>(nullable: true),
                    PhoneUs = table.Column<string>(nullable: true),
                    PasswordUs = table.Column<string>(nullable: true),
                    AddressUs = table.Column<string>(nullable: true),
                    ProfileImageUs = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(nullable: true),
                    TimeLogIn = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Random_Link = table.Column<int>(nullable: false),
                    RPass = table.Column<string>(nullable: true),
                    NameFamily = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    TokenPhone = table.Column<string>(nullable: true),
                    CodeNational = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminPays");

            migrationBuilder.DropTable(
                name: "tb_GalleryProducts");

            migrationBuilder.DropTable(
                name: "tb_ImageGalleries");

            migrationBuilder.DropTable(
                name: "Tbl_Adress");

            migrationBuilder.DropTable(
                name: "tbl_Advertisings");

            migrationBuilder.DropTable(
                name: "Tbl_Agencie");

            migrationBuilder.DropTable(
                name: "Tbl_Baner");

            migrationBuilder.DropTable(
                name: "Tbl_Blog");

            migrationBuilder.DropTable(
                name: "tbl_category");

            migrationBuilder.DropTable(
                name: "Tbl_Comments");

            migrationBuilder.DropTable(
                name: "Tbl_Experts");

            migrationBuilder.DropTable(
                name: "Tbl_Factors");

            migrationBuilder.DropTable(
                name: "Tbl_Factors2");

            migrationBuilder.DropTable(
                name: "Tbl_Financial");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_Logo");

            migrationBuilder.DropTable(
                name: "Tbl_Message");

            migrationBuilder.DropTable(
                name: "Tbl_MyFavorites");

            migrationBuilder.DropTable(
                name: "Tbl_Order");

            migrationBuilder.DropTable(
                name: "Tbl_Originality");

            migrationBuilder.DropTable(
                name: "tbl_Pays");

            migrationBuilder.DropTable(
                name: "Tbl_Price");

            migrationBuilder.DropTable(
                name: "Tbl_Product");

            migrationBuilder.DropTable(
                name: "Tbl_Richats");

            migrationBuilder.DropTable(
                name: "Tbl_SendNumberCodes");

            migrationBuilder.DropTable(
                name: "Tbl_Slider");

            migrationBuilder.DropTable(
                name: "Tbl_SocialNetwork");

            migrationBuilder.DropTable(
                name: "Tbl_Teaser");

            migrationBuilder.DropTable(
                name: "Tbl_User");

            migrationBuilder.DropTable(
                name: "Tbl_Users");
        }
    }
}
