using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lucky.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ce7ef9a-2b43-4afc-a3b0-870ecf99bec1", null, "Administrator", "ADMINISTRATOR" },
                    { "761a66be-0a7b-495e-81f4-7ca6ab3ee223", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02cdca4e-6837-469f-97cd-d54e848e5e30"), "Yemen" },
                    { new Guid("034941fe-69cb-470c-817d-958371d021fe"), "Bolivia" },
                    { new Guid("03774b3d-89fe-491d-a605-09db09995d46"), "France" },
                    { new Guid("03d48c6e-324f-4853-a80c-404b772ddba7"), "Faroe Islands" },
                    { new Guid("03e934ba-21b8-47dc-9039-040950cda184"), "Liberia" },
                    { new Guid("04f3ebd6-7155-422e-8bf6-785895cb4bcd"), "Saint Pierre & Miquelon" },
                    { new Guid("05405ee7-d8ad-4c49-b82c-525ad5d04877"), "Ecuador" },
                    { new Guid("05cebbc0-1166-41ed-9c14-cb8b680b388d"), "Panama" },
                    { new Guid("062afa97-5392-4282-b9e9-8d72856765e8"), "Finland" },
                    { new Guid("069603fe-c371-42c4-8e5b-5440d3a11589"), "Mauritius" },
                    { new Guid("079d12a9-16df-4084-a146-64016f9c4910"), "Montenegro" },
                    { new Guid("09a5d75c-7d2c-4a11-876d-c89ba441905c"), "Dominican Republic" },
                    { new Guid("0b560f87-605c-4622-9fb3-21e82662b9dd"), "Seychelles" },
                    { new Guid("0c9b4a54-5bf5-47bb-b8b5-b9a0f53974f2"), "Niger" },
                    { new Guid("0d1eda21-2dcb-4d1a-8c51-1e77de26e52a"), "Puerto Rico" },
                    { new Guid("0d8badf4-e522-46e2-bbaa-adab28b44058"), "Netherlands" },
                    { new Guid("0dd9d748-6bce-4433-9ed2-597e1dfa6d7c"), "Zambia" },
                    { new Guid("0dea7590-b792-481b-b0df-45bdfd3a1b56"), "Cote D Ivoire" },
                    { new Guid("0e60df3f-e199-486e-a776-e58ab1d34008"), "Qatar" },
                    { new Guid("0e8ad512-5027-4cd6-8296-568ad92ce21f"), "Bulgaria" },
                    { new Guid("112f5ac5-02a6-4435-a5d9-dd97c2af6e2a"), "Macedonia" },
                    { new Guid("131ba1f2-5738-493a-ab0e-0ac8714bc882"), "Senegal" },
                    { new Guid("137e0ac2-d8a5-424b-958b-0c74b3b7fe30"), "Austria" },
                    { new Guid("13ebdea2-f6d5-4a5b-892e-cef9a4ae3540"), "Haiti" },
                    { new Guid("1468f7b2-f4ae-4db7-9ece-ea034e226b09"), "St Lucia" },
                    { new Guid("14bb8eff-95a9-4c0b-9e02-3ec6a1eac3ee"), "Sierra Leone" },
                    { new Guid("156efa69-5aab-4582-a2b7-f91df77eafe7"), "Denmark" },
                    { new Guid("1575eb9a-2644-457a-9dae-708fe27dcbc3"), "Uruguay" },
                    { new Guid("1580cb65-e019-476b-8431-98bc28a1e7a6"), "Slovenia" },
                    { new Guid("1612ee90-2255-4dd7-98de-c4125aa80832"), "Spain" },
                    { new Guid("1682f92b-9eba-4fd4-b24d-b70c976c349f"), "Estonia" },
                    { new Guid("1bc67cdc-5d66-47eb-9fea-484d3b61028a"), "Anguilla" },
                    { new Guid("1c92d022-e2d8-4f78-b9f0-3e86846e06ea"), "Pakistan" },
                    { new Guid("1ca6b007-91ae-4376-875b-40e2d2bbe989"), "Mali" },
                    { new Guid("1cc89748-3658-4dad-a727-993840b8cea1"), "Morocco" },
                    { new Guid("1d23e466-306e-4861-8015-22ea37862724"), "Italy" },
                    { new Guid("1e8a91c6-9374-4e11-8c60-b08b1a3400e9"), "Guernsey" },
                    { new Guid("1eb01a8c-b66d-46f3-af3e-b59dcdabf3a1"), "Mozambique" },
                    { new Guid("1f77f181-ed8c-42d7-9782-8aea193f0771"), "Madagascar" },
                    { new Guid("20bdb5d6-1238-48e8-8785-aeb88411bf5e"), "Venezuela" },
                    { new Guid("220fcbaf-5d3c-41dc-8d35-aa041c28c0d8"), "Taiwan" },
                    { new Guid("2270b336-468e-4af6-abe3-8630bf29c066"), "Samoa" },
                    { new Guid("22847107-f4cd-4f69-bea3-d616e009caf3"), "Turkmenistan" },
                    { new Guid("238ca987-7f1e-4ee0-8cf8-9cdbba2fa92a"), "Slovakia" },
                    { new Guid("24bb75b1-131f-447d-bfbe-22843e15a6f6"), "Uganda" },
                    { new Guid("28071394-0c65-4046-aefc-8d103de5ef14"), "Greenland" },
                    { new Guid("2864ea4e-9535-4ed5-8e15-8e5946c9193a"), "Trinidad & Tobago" },
                    { new Guid("2accc044-9903-47fb-a5dd-2f769af47e27"), "Fiji" },
                    { new Guid("2b84de2e-f9be-45c8-8de6-be33af42a1d9"), "Botswana" },
                    { new Guid("2e4dcdfc-5bb0-4ea4-9476-086cf83bf114"), "Cruise Ship" },
                    { new Guid("2e5afd0e-4339-4c3c-8fdd-dd95ff8073a6"), "South Africa" },
                    { new Guid("2ebe22f3-9249-498b-8cc5-18efb08820d8"), "Israel" },
                    { new Guid("2ee945b1-a90c-4146-bd7d-a58ef371d310"), "Nepal" },
                    { new Guid("31c51f18-712b-4552-9170-5ea37aa9a999"), "Poland" },
                    { new Guid("33c08db8-e04e-4c24-8551-8f284be56c69"), "Russia" },
                    { new Guid("33ee468b-e594-41b2-a2fa-ddfeeef452b2"), "Aruba" },
                    { new Guid("3671bcdc-dfeb-4418-b292-6434e23b05ec"), "Georgia" },
                    { new Guid("37c5b928-1d6e-4917-96d2-706476b22b31"), "Nicaragua" },
                    { new Guid("38216bc0-1edc-4a40-9d20-f60d908d48cc"), "Switzerland" },
                    { new Guid("3978058b-dffe-4ca2-b9a2-43b6ca125708"), "Lithuania" },
                    { new Guid("3a2089e4-2152-46be-adfb-98ecb3a277bb"), "Jamaica" },
                    { new Guid("3b1f5161-3fb8-4461-ba8c-45c3c2114425"), "Ireland" },
                    { new Guid("3c88106b-bdf6-439c-bcfa-a97dc1d1fc87"), "Bahrain" },
                    { new Guid("3d528091-21b4-42cf-97f1-857f6641d74c"), "Lesotho" },
                    { new Guid("3d7f2106-12d0-4814-b973-1d0d49b1c0cc"), "Belgium" },
                    { new Guid("40287b8c-eccf-49c1-af3e-f76b97c269c4"), "Czech Republic" },
                    { new Guid("40c2f660-3ceb-4249-9dca-e82d6434a1d0"), "Swaziland" },
                    { new Guid("417ae0ed-4c4c-4d0f-a880-f8a5ebab860e"), "Sweden" },
                    { new Guid("42fafe24-76f8-4f33-bb8d-c42c5452492a"), "Satellite" },
                    { new Guid("43c59f8f-a62b-4a97-b28f-c1a89dd61ce0"), "Uzbekistan" },
                    { new Guid("43cbe1f4-3ff6-4e8c-94d9-a181369377a6"), "Kazakhstan" },
                    { new Guid("443ef338-40c2-498b-bb61-60a606415e21"), "Reunion" },
                    { new Guid("48de87e9-836e-4df2-8b45-3ccb993e06f3"), "Afghanistan" },
                    { new Guid("492b467c-9f53-42c6-a72c-6c990189034b"), "Lebanon" },
                    { new Guid("4a3621b1-f7cc-443c-ab65-c216e9f9b52b"), "Timor L'Este" },
                    { new Guid("4acedf20-4d95-4b40-b161-3c8036b6684c"), "Guatemala" },
                    { new Guid("4b60d316-9afa-4efe-9cb1-1e1ff29c0dc9"), "Syria" },
                    { new Guid("50cde23a-ca65-4b0c-a6e3-6621a6277c4e"), "Kenya" },
                    { new Guid("51b5e841-7a06-4306-b640-8f62a5daf281"), "Norway" },
                    { new Guid("52f002e1-a1c5-4e3f-9d13-7cca6a4415f8"), "Falkland Islands" },
                    { new Guid("54c06d7e-c26b-4e67-ab7c-ec59a326636e"), "Cook Islands" },
                    { new Guid("551b83df-2e73-4f24-a4c6-5db4b2003cbb"), "Guinea Bissau" },
                    { new Guid("57d94c57-de23-4142-bfe7-1d8c23d3d719"), "Namibia" },
                    { new Guid("5a422918-dd9c-41b7-8ecb-70f0c16acc2c"), "Montserrat" },
                    { new Guid("5c264571-2d6f-4f90-9591-21cc58dc2f32"), "Iran" },
                    { new Guid("5c3a507a-d435-4b55-8518-ced7be6dbb25"), "Benin" },
                    { new Guid("5d721fd0-dfc2-4846-bdd1-88dfa10adad7"), "Papua New Guinea" },
                    { new Guid("62d48a74-22d8-48e2-8906-dbc3954fb929"), "Brunei" },
                    { new Guid("64fce4f5-412b-425f-b640-d57d33b2a2ca"), "Armenia" },
                    { new Guid("66244bd0-075c-41f1-bacd-347597b38bd7"), "Bosnia & Herzegovina" },
                    { new Guid("66850872-80db-43f2-aead-b31952f2b174"), "El Salvador" },
                    { new Guid("674b5781-86e9-4504-8025-bb25348fbd64"), "Maldives" },
                    { new Guid("674d5ad2-58df-4a05-b286-01e2f6cf767c"), "Portugal" },
                    { new Guid("678dc09a-dd87-4be0-96ce-d19f3c78ca2f"), "Cayman Islands" },
                    { new Guid("68af9a21-3d49-4b6f-a757-f17e71a57d99"), "Cyprus" },
                    { new Guid("69196a53-d1e7-44eb-9189-a0a568f269a8"), "Netherlands Antilles" },
                    { new Guid("69f00403-e218-4b75-8162-48bc1adf7191"), "Indonesia" },
                    { new Guid("6bd6ff01-f98c-421b-818e-862006afc97c"), "China" },
                    { new Guid("6be045c6-3d3f-47b6-8ad9-4d582189dc94"), "Cape Verde" },
                    { new Guid("6d3cf893-7947-4ae3-9deb-5aedc10d62e1"), "St Vincent" },
                    { new Guid("71763e8a-97b7-4949-85b6-f3f5321de8e7"), "Ethiopia" },
                    { new Guid("71771787-d3b0-428d-8973-20d9aa4cda99"), "Angola" },
                    { new Guid("7285a174-2d26-4904-a844-30311eabbb63"), "Macau" },
                    { new Guid("74a5a5ed-afd4-4b29-84d1-6a885d091bfa"), "Barbados" },
                    { new Guid("74a9130c-e49f-4af2-b95f-061d12b733d3"), "Malta" },
                    { new Guid("7671dd13-fab5-441a-8551-f905e299a8fd"), "Turkey" },
                    { new Guid("790012f4-f76d-4dcc-8080-4190b2b04206"), "St. Lucia" },
                    { new Guid("796d62c1-b250-495e-b815-53ad21e24558"), "Guyana" },
                    { new Guid("7a3d95ba-1f6a-4cbe-887f-c0b5856a783c"), "Latvia" },
                    { new Guid("7be537c8-8ad0-4cb6-92a3-200e5d6752c3"), "Tanzania" },
                    { new Guid("7e7513bb-bd27-46dc-b0e6-56b01a73a9cf"), "Egypt" },
                    { new Guid("7e7b55b9-95f6-44a9-89ff-4a5ec6129dc5"), "Guam" },
                    { new Guid("7f45928b-7f67-4c16-88d4-a89db1a973b8"), "United Arab Emirates" },
                    { new Guid("7f997330-9862-42f3-88e7-0007b87b137a"), "Philippines" },
                    { new Guid("856c8c3d-3215-49d7-877c-8f562d39877b"), "Malawi" },
                    { new Guid("86e829a8-79df-4d78-a8c2-895b298f3c83"), "Greece" },
                    { new Guid("8740fdb1-9e9b-4ec4-b639-4e5d95b311cc"), "Belarus" },
                    { new Guid("88207ef3-230d-4717-8faf-106cd398a497"), "Gabon" },
                    { new Guid("88775215-1555-489a-b851-2deb3f5373e7"), "Mongolia" },
                    { new Guid("88d45569-74c0-497f-9117-222e0fae1c8d"), "Cameroon" },
                    { new Guid("8935ae21-0f16-484a-b4df-895cb21be33b"), "Malaysia" },
                    { new Guid("8af3677f-a974-467e-839b-bca6f45c60f9"), "Burkina Faso" },
                    { new Guid("8aff1e2d-4932-44ab-9cd9-f3c7d930425b"), "Luxembourg" },
                    { new Guid("8b99ef9e-57bd-447b-84ef-c5978afd31ce"), "Jersey" },
                    { new Guid("8c56771e-54d0-4288-b3c7-aff3e1dfe444"), "Gambia" },
                    { new Guid("8dfb497b-7573-41b6-bd09-1a4dc88240f8"), "Ukraine" },
                    { new Guid("8e106375-1645-436f-bad9-9ab13632c8b9"), "Romania" },
                    { new Guid("8e92a895-b65d-4f9f-a400-f0b41d2b3bda"), "Ghana" },
                    { new Guid("91c34640-174f-4fe1-8167-51db5c5b8cec"), "Cambodia" },
                    { new Guid("9370835b-a669-4f4e-b02f-5a84baa58d2f"), "Palestine" },
                    { new Guid("93821650-3956-4022-8a8a-7029faaffcf2"), "Tonga" },
                    { new Guid("938746f4-78c4-4302-94f9-6af40e2d4d00"), "Oman" },
                    { new Guid("96a19464-2e5f-4e5c-9817-9760841e20b9"), "Hungary" },
                    { new Guid("98867015-fefd-4c96-88be-b690480a3a7f"), "Honduras" },
                    { new Guid("98b32560-e592-4d1c-bb17-ac012ec0ba34"), "Moldova" },
                    { new Guid("9bbe0719-99a6-495d-b942-09dfb455dce7"), "Grenada" },
                    { new Guid("9bdaf964-8bf6-46fa-843a-16e267e0eea8"), "Germany" },
                    { new Guid("9e8739bc-54fe-44c1-8e18-d019b35a5d2e"), "Libya" },
                    { new Guid("a0b592fe-a117-4277-85ae-fc0692c9557a"), "Kuwait" },
                    { new Guid("a15226d3-acf0-4db6-8a4e-c657cc95954d"), "Suriname" },
                    { new Guid("a2647c64-6e50-4bee-baa9-6e260b136f8f"), "Andorra" },
                    { new Guid("a2bc27ea-6b88-4ae0-8cef-6c45138ce06b"), "Bhutan" },
                    { new Guid("a3e4a3a6-23d5-48b3-8c7f-7df88ae4476a"), "Gibraltar" },
                    { new Guid("a53f6216-7960-4826-8bd9-049d7a365d2f"), "Colombia" },
                    { new Guid("a700d5b3-5857-4ff6-b2f6-69a1973ee5be"), "Serbia" },
                    { new Guid("a71c4d53-a59a-4311-92b8-0ac219defa9e"), "Costa Rica" },
                    { new Guid("a8ff874c-dfc5-4e61-a2dc-cadb2c897951"), "Togo" },
                    { new Guid("ac0ab210-133a-4fae-a421-2910ebf20c32"), "San Marino" },
                    { new Guid("ac77d4cd-67c4-4877-8ed1-719c75ceef40"), "Congo" },
                    { new Guid("b0f95888-a663-432a-874f-d93618a064c2"), "Belize" },
                    { new Guid("b1991edf-51e7-4ebb-ae8d-5fbb2acb85f8"), "Kyrgyz Republic" },
                    { new Guid("b1b15e76-9bb3-49d3-a2f9-358f1b4a04bf"), "New Zealand" },
                    { new Guid("b1e95999-4695-415e-bc85-611099c6f3be"), "Sudan" },
                    { new Guid("b271c2f7-f80e-425d-9b0f-21c80c7f8a95"), "Thailand" },
                    { new Guid("b3170691-d741-45ba-839a-365d30d40639"), "Nigeria" },
                    { new Guid("b4fff672-1669-4951-9d4e-3816eed13e65"), "Algeria" },
                    { new Guid("b601ff02-2efb-4e68-af77-73eee31d4fce"), "Japan" },
                    { new Guid("b6c64794-b142-44d7-b246-1ed50ec4f00b"), "Vietnam" },
                    { new Guid("b6e32108-fada-4480-81a8-016b8caa3216"), "French Polynesia" },
                    { new Guid("b6e496fa-a8c1-4555-a6b8-6d50a4c0aac8"), "Brazil" },
                    { new Guid("b7556d19-f514-4f50-847b-fc435bbeb391"), "Monaco" },
                    { new Guid("b9fe4522-7372-433d-9a11-63fa7784e180"), "Guinea" },
                    { new Guid("bbbc39b3-fcd9-48a4-affc-4f40d3ba56dc"), "Rwanda" },
                    { new Guid("bc2ea133-0b9f-46eb-a61f-d27612eb08c6"), "Saudi Arabia" },
                    { new Guid("bc7a5c6b-5ddf-4ebd-99d7-299a2611f0f0"), "Djibouti" },
                    { new Guid("c114bd03-9914-4f23-a1c4-0a2eb640d746"), "Bahamas" },
                    { new Guid("c54a557c-2aac-45af-aa6a-d0b9280a5fdc"), "India" },
                    { new Guid("c68b0b4f-a3cf-499a-bf25-cb022fcc7407"), "Chad" },
                    { new Guid("c984ec06-e919-4338-be9f-9cd69e416e3e"), "Isle of Man" },
                    { new Guid("c9da3942-58e9-4b6a-965e-ff43cc2bbfc3"), "Hong Kong" },
                    { new Guid("cc65bcac-f1dd-49c5-9d03-2b17659d6f04"), "Turks & Caicos" },
                    { new Guid("cc9e007c-8c3b-49d8-9fce-efcfabfd0470"), "Burundi" },
                    { new Guid("cf82dff8-78fb-4f8e-a5aa-9e383831af87"), "Sri Lanka" },
                    { new Guid("d783cc38-4c78-4e3c-b3cc-bcdaa2492626"), "Chile" },
                    { new Guid("d8654057-d6a6-4444-a1b9-36ed4ca382fa"), "Dominica" },
                    { new Guid("dac0b82e-170c-4e2f-a62a-3335ce67e8e7"), "Tunisia" },
                    { new Guid("daf3cc91-88ec-4aeb-b6a5-5ddf9936eaa7"), "St Kitts & Nevis" },
                    { new Guid("dc091681-7bb9-40b2-8a2e-6c3a5396592c"), "South Korea" },
                    { new Guid("decf95bd-3da1-4548-916b-25d70ab048ac"), "Croatia" },
                    { new Guid("dfbcbd75-3132-477d-80e1-ff8aee3df988"), "French West Indies" },
                    { new Guid("e0f4cfc5-dc1b-4fc9-bdb9-74b344db0a73"), "Azerbaijan" },
                    { new Guid("e13fb841-d22d-4171-9ea6-d27c95374351"), "Laos" },
                    { new Guid("e30ba8af-c721-476c-87fd-b2be17917654"), "Mexico" },
                    { new Guid("e31578d4-fd50-4e95-98a2-75e66ea39228"), "Jordan" },
                    { new Guid("e4a9dc69-e48e-4cd6-a04f-4b91f9f0624f"), "Paraguay" },
                    { new Guid("e4b46a14-7ab8-488f-8c50-6ab874c3b52e"), "Iceland" },
                    { new Guid("e5517761-37a6-4717-be35-def2e3163fe5"), "Zimbabwe" },
                    { new Guid("e83726cf-d512-4484-9b1c-cd92a4c9f444"), "Argentina" },
                    { new Guid("e8f0d0bf-d36c-4b11-9205-38ff7487e24b"), "United Kingdom" },
                    { new Guid("ee540ec4-d5dd-40e2-b04e-021082b30340"), "Cuba" },
                    { new Guid("ee72220a-ffc2-45c1-84a4-2ed3b0734d18"), "British Virgin Islands" },
                    { new Guid("ee90cad5-182c-458f-b8be-0e765620858f"), "Mauritania" },
                    { new Guid("ee9b2f1f-a533-4ae5-86a7-bad001b11505"), "Albania" },
                    { new Guid("effe9ff4-0640-4893-92f8-1e5341fc09b3"), "Bermuda" },
                    { new Guid("f04fdfa7-e0e4-44f0-ae48-dd9341478ad2"), "Liechtenstein" },
                    { new Guid("f208f4de-b3ee-4b76-9e81-594bc18c334e"), "New Caledonia" },
                    { new Guid("f290c401-05ed-467c-9302-606bc0f37d30"), "Iraq" },
                    { new Guid("f386d7ab-8495-48db-9232-88446b448b1f"), "Equatorial Guinea" },
                    { new Guid("f3dad9b6-c326-4724-a643-5a90785e871a"), "Singapore" },
                    { new Guid("f4e7b80b-e50e-4768-ab35-d64b8df49c16"), "Peru" },
                    { new Guid("f6733424-ec02-4ec2-ae2f-833a387c4de0"), "Antigua & Barbuda" },
                    { new Guid("f68e28c2-fc27-408c-8169-5b87e17c5318"), "Australia" },
                    { new Guid("f6f0b911-ae9a-4a8a-a0ed-1cc272bd1a5f"), "Bangladesh" },
                    { new Guid("f7e306c0-13b4-4a92-9d95-ab59c79a9815"), "Tajikistan" },
                    { new Guid("f89841b2-c6fa-4cf5-a366-338522ea2e74"), "Virgin Islands (US)" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("082e5892-97df-4f35-943c-58627d90e64a"), "Hungarian" },
                    { new Guid("0d1c2001-7cf2-4c95-8065-c279b0537914"), "Turkish" },
                    { new Guid("1113102e-91a5-4ce3-ab4f-0a88bdeb50aa"), "Bengali" },
                    { new Guid("1a9b52ac-7819-4741-ac7f-ff31df7d8111"), "Croatian" },
                    { new Guid("1d6335ef-c1df-48a6-a9af-fb88ea060dda"), "Arabic" },
                    { new Guid("2249a261-8a61-4007-a418-fb00317b2f66"), "Persian" },
                    { new Guid("24222ac3-5f5d-4d57-81d1-23ba6de10f20"), "Urdu" },
                    { new Guid("259683a2-5873-440f-9589-abb91fd77d4a"), "Telugu" },
                    { new Guid("2e42aa1f-0b39-4e01-9ebb-8fc914483443"), "Lithuanian" },
                    { new Guid("33cd9c28-ee12-4ac4-b39b-646820eacf22"), "Hindi" },
                    { new Guid("36454958-91ee-40ff-bccc-44c91da1f2cb"), "Indonesian" },
                    { new Guid("4524a510-f6bb-417d-8a5a-afb2412d8b59"), "Vietnamese" },
                    { new Guid("479876f7-52a0-43aa-a24f-e9fc450fbdb4"), "Kannada" },
                    { new Guid("4dad680e-434c-4245-815b-bb5484e7fbb6"), "Danish" },
                    { new Guid("4e1643bc-e820-44f2-9315-5e386d549095"), "Russian" },
                    { new Guid("4f37fc95-a72c-4ca3-834e-82f921b23f65"), "Swahili" },
                    { new Guid("579b5297-142e-4c15-999a-4e5a31ca8132"), "Gujarati" },
                    { new Guid("6514cc3b-3db6-4aae-962a-1b9924c16690"), "Estonian" },
                    { new Guid("656240a4-6787-4f05-a035-bf9709e53b45"), "Albanian" },
                    { new Guid("6f2a0643-888f-4d5c-b6d9-973013973219"), "Macedonian" },
                    { new Guid("7170754a-8906-45a3-a881-d2381a002bf0"), "Dutch" },
                    { new Guid("74e1cbc8-6bf1-4099-a89b-460b9139ff6e"), "Hausa" },
                    { new Guid("75121da2-9e0b-4177-8b2a-9ef520ea77b8"), "Slovenian" },
                    { new Guid("7812670e-e037-425f-9209-7d8654d9ce57"), "Portuguese" },
                    { new Guid("78313aea-ff61-4a59-b7c2-a7213531a1a9"), "Spanish" },
                    { new Guid("7b87360e-39df-454b-b981-449f4f7da5ed"), "Mandarin Chinese" },
                    { new Guid("821dae90-15ef-4a9a-b5f2-e2f594b7d4d5"), "English" },
                    { new Guid("879374e8-cb13-4791-8c61-fb31c2fe2e65"), "Greek" },
                    { new Guid("88088164-c872-40b3-983d-9298cf6fa7b3"), "Bengali" },
                    { new Guid("8e4245f3-ef64-4a2b-898f-89ec530f7fa2"), "Finnish" },
                    { new Guid("8f14addc-9a3d-4352-94d5-119bbebec9b4"), "Punjabi" },
                    { new Guid("90df22e4-e9b4-43fe-8b61-30ed75c3e1c8"), "Slovak" },
                    { new Guid("97bb9584-c991-435c-86f6-1c12817d60ab"), "Malayalam" },
                    { new Guid("a4389166-3211-4f45-af6c-5cc9e40e6010"), "Hebrew" },
                    { new Guid("ab5abc66-91a4-4919-ac1e-cf7d8d1c32f6"), "Japanese" },
                    { new Guid("ac97a930-7513-4c73-8759-35a814bf261a"), "Czech" },
                    { new Guid("b19c0d5b-1f94-4b36-b330-3cea49807fd4"), "French" },
                    { new Guid("c209ee3c-7963-4e1b-be9f-92c4b096b3e0"), "Georgian" },
                    { new Guid("c36bf4e4-3ade-4104-b558-9b7d45c8c0cb"), "Armenian" },
                    { new Guid("c949782e-91fb-4508-9612-c1b05f12172e"), "Bulgarian" },
                    { new Guid("ca4c5c6f-6ac6-4116-864f-5253d0074774"), "Polish" },
                    { new Guid("d0600605-3f3f-43d5-9463-7146badd5443"), "Malay" },
                    { new Guid("d5acb6d1-e0c1-45d2-ac4a-cd85e0f9818f"), "Swedish" },
                    { new Guid("db79b931-ce04-465e-b188-1bc22b3bc979"), "Thai" },
                    { new Guid("e1167006-7f97-4177-a937-71781e712edd"), "Korean" },
                    { new Guid("e172040f-ac67-4733-9384-e79b5b679803"), "Tagalog" },
                    { new Guid("e24ec3ed-0fa0-48e0-b1a2-95fb1804380e"), "German" },
                    { new Guid("e5af7e6f-df26-4227-9309-ab7f67fc0e8b"), "Latvian" },
                    { new Guid("e9314f48-44d7-40a7-a62c-72e6b47d8940"), "Norwegian" },
                    { new Guid("ebe337cd-e208-402c-a2ae-18383adb36d6"), "Tamil" },
                    { new Guid("edf894b6-aabe-4790-95d1-fe491eea4073"), "Italian" },
                    { new Guid("ee56b053-ee5b-4eb9-aac7-97e79e687883"), "Marathi" },
                    { new Guid("f3333186-b936-4437-842d-52cda768b072"), "Ukrainian" },
                    { new Guid("f4d21bee-d16d-4fd5-987e-11dbcb3aaea2"), "Serbian" },
                    { new Guid("fb91edfe-dd40-4252-b82e-0319e6afe284"), "Romanian" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
