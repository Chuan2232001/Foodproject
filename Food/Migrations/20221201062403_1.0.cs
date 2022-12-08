using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Food.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "3b830e26-6123-498c-a73b-9781599a71bd");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "df8a5675-3d3e-4ec5-b96d-9719ad55d28c");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "69f9af4a-90b1-4f24-b553-5df615f0fc2e");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "6fea5196-8897-4f26-88f6-6f116afc22b5");

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "039b9b53-e7ff-435e-ab44-666ca5cb0262" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "03b02d76-6014-4758-b863-b66dea5a84f2" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "0e4a08a3-ce67-4bb9-877d-1d7b3ed7de01" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "198f2c03-15d9-4964-89cc-0f85d19debe6" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "219e4f80-4108-488c-8927-d5611b83e07f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "71f3d393-3be7-4db9-b8fc-87ceb9c22402", "24cd3345-f191-410e-861f-9d6c171b79f1" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "d8ab4da3-085e-488d-beec-17795a11f33e", "320ee4e4-5a27-4848-83fc-cdc92c139baa" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "3e865ddb-e69d-417a-a517-443ded410dd8" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "4e99358c-883a-4d51-8099-4b15037d65ed" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "59bdb3d1-f663-49f4-ac4c-a5f1e5a0eac9" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "69b258a1-b710-425b-ad33-ebc7a7520709" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "70119e6c-eab8-4e49-b187-050f7a7efb49" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "d8ab4da3-085e-488d-beec-17795a11f33e", "93b5af59-8956-42cc-b7f4-7a5b8252345b" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "946cc541-0441-4b77-81e1-b4390397b9d3" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "99182378-29a6-442b-83e8-25900b92d4c4" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "a6f36a54-d0b5-4c8c-b1ea-66621ffa5fb0" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "b21ee332-770d-4e16-9d97-41122a7b6ee1" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "bf492cd5-3553-47fa-b053-74897d89adc0" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "c14b3a01-e00b-4182-b385-7f326815ef20" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "c460d4bc-7341-4a5f-914d-922cff462535" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "c9b32e91-15cd-40d5-85c7-45874c7b4f07" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "d8ab4da3-085e-488d-beec-17795a11f33e", "d437cfde-c033-4ec9-a8df-d6dcbc34715a" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "71f3d393-3be7-4db9-b8fc-87ceb9c22402", "d5c5a167-3e45-4e57-8f2b-c49d3b1f8aa4" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "d8ab4da3-085e-488d-beec-17795a11f33e", "e25e9bbd-d208-4495-a903-7996da649735" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "d8ab4da3-085e-488d-beec-17795a11f33e", "e70915e3-0814-420b-99df-9376841d5f8d" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "7679dc40-a09a-49de-bc78-e48c28e00384", "eb4dd6a0-3bf2-4c8a-a430-37f720e70f91" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "f056c48b-1819-4b56-be86-270177cbe16d" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "f149b954-6888-4c6f-a2c8-18046a9f2f8b" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "e25e9bbd-d208-4495-a903-7996da649735", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "e25e9bbd-d208-4495-a903-7996da649735", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "e25e9bbd-d208-4495-a903-7996da649735", "EEBA6608-AB75-4E83-909F-604B1A06F16C" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "b606dd1b-dafd-4a0c-bac0-2a7ed50fe172" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "2222ff20-ec5e-4bcc-b5d7-173bc5be1a50" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "eb7e82bb-0354-41ca-be00-fcccdc75edd1" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "71f3d393-3be7-4db9-b8fc-87ceb9c22402");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "7679dc40-a09a-49de-bc78-e48c28e00384");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "d8ab4da3-085e-488d-beec-17795a11f33e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "e9a2c00e-4fd6-4796-8449-ab7fb63dc416");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "fb1bb6f5-6010-496c-a459-bc7968bedd94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "039b9b53-e7ff-435e-ab44-666ca5cb0262");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "03b02d76-6014-4758-b863-b66dea5a84f2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0e4a08a3-ce67-4bb9-877d-1d7b3ed7de01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "198f2c03-15d9-4964-89cc-0f85d19debe6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "219e4f80-4108-488c-8927-d5611b83e07f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "24cd3345-f191-410e-861f-9d6c171b79f1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "320ee4e4-5a27-4848-83fc-cdc92c139baa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "3e865ddb-e69d-417a-a517-443ded410dd8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4e99358c-883a-4d51-8099-4b15037d65ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "59bdb3d1-f663-49f4-ac4c-a5f1e5a0eac9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "69b258a1-b710-425b-ad33-ebc7a7520709");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "70119e6c-eab8-4e49-b187-050f7a7efb49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "93b5af59-8956-42cc-b7f4-7a5b8252345b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "946cc541-0441-4b77-81e1-b4390397b9d3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "99182378-29a6-442b-83e8-25900b92d4c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "a6f36a54-d0b5-4c8c-b1ea-66621ffa5fb0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b21ee332-770d-4e16-9d97-41122a7b6ee1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "bf492cd5-3553-47fa-b053-74897d89adc0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c14b3a01-e00b-4182-b385-7f326815ef20");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c460d4bc-7341-4a5f-914d-922cff462535");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c9b32e91-15cd-40d5-85c7-45874c7b4f07");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d437cfde-c033-4ec9-a8df-d6dcbc34715a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d5c5a167-3e45-4e57-8f2b-c49d3b1f8aa4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e25e9bbd-d208-4495-a903-7996da649735");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "e70915e3-0814-420b-99df-9376841d5f8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "eb4dd6a0-3bf2-4c8a-a430-37f720e70f91");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f056c48b-1819-4b56-be86-270177cbe16d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "f149b954-6888-4c6f-a2c8-18046a9f2f8b");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "2222ff20-ec5e-4bcc-b5d7-173bc5be1a50");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "b606dd1b-dafd-4a0c-bac0-2a7ed50fe172");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "eb7e82bb-0354-41ca-be00-fcccdc75edd1");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 12, 1, 13, 24, 2, 712, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "Snack", "", "" },
                    { "22d2f0de-4b82-4de3-be7f-c1023398fbfe", "Banhmi", "", "" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "Dry food", "", "" },
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "Food", "", "" },
                    { "8687b07e-038b-43a0-8f6c-40825656e492", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "ccf09f19-a11c-497f-9e93-f574fc1f9468", "Huntsville, AL 35813, USA", "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.", "support@foodshop.com ", "021.343.7575" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "c0c31443-5360-47e0-a28c-0f5a38deedfd", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "7ca3df06-5ddc-4be8-bfed-08ad6b74e2a9", "code10", 10 },
                    { "77f08e2d-e167-49ef-bb27-beba332a92a3", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "isDelete", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "678e5914-dc06-4d15-94fc-bb22c2996a5c", false, "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "37493c5e-e014-4b79-b39e-74e968863127", false, "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "66eaa150-c9b5-4bf3-8ae0-d7bde5e53116", false, "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "658da0b6-b8ad-4a37-ac6e-628581ed3742", false, "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "922899af-be3a-4046-9124-eeac5be5d06d", false, "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d7ea2327-f5cc-4eae-990f-fbd35616ad4f", false, "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c66d3d35-d292-4adb-8412-fcf970f584b6", false, "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "cbfd0aa8-a64d-438a-85be-4464374e5e73", false, "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "413ad81f-bbb2-41de-89f8-3fd701b2d8d6", false, "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c543626b-1591-4f0c-a1ca-370649ee64e9", false, "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "8226a07a-4dbf-4d5d-94c4-ababa52ea246", false, "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "2b618658-c78a-4c0e-8bf2-2f0c1570920e", false, "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "b2289829-9410-4074-9f99-3e4a93ec19e8", false, "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d34000ff-a72a-462e-9c37-5cb0405d01f3", false, "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "ddbafbfe-fd40-44bd-b338-4825f7946c01", false, "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "40540fc0-ee18-44e5-932f-fbec03452ca7", false, "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "960f6e91-244c-4d49-8f55-fdc2bd9a1ee8", false, "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "60555bef-ded6-4b92-83e3-97e8c46f0d71", false, "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "7e72cc5f-67f2-4b7c-a69b-29c2b69154cf", false, "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "cdd46832-ad85-446b-8e0c-82fa5e2da987", false, "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c4035cec-6b81-4430-937c-86a0f27312ad", false, "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "ed5e7364-9d0f-46ba-8e18-84c0a272e66c", false, "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "413442aa-2f9f-4a31-bfec-caa3b4c17c48", false, "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "4873b3ff-0e1b-4ddb-9600-ac6092ac6c51", false, "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "af354cdd-d715-4937-873a-6680ad908f56", false, "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "73b0edc3-9413-4bf4-a1df-70268447264d", false, "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0a29137b-8769-4c6c-a7eb-3bf84022a857", false, "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0f67950f-e914-4bae-95f8-40c4fd73375c", false, "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "74ec700a-1157-43f2-8260-ac544524a22f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "008a2cf1-8332-4119-8b3a-7fbf1f53b710");

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "ffa68b47-0100-46b7-ae56-aad0fb5baec5", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "b51c5fab-191d-4340-ba6d-409307a82b7d", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[] { "0f66089b-4172-4437-a867-2bb169c58e0f", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d7ace04-e5e6-478b-a6df-fb0615fd889c", "AQAAAAEAACcQAAAAEAdwYA5j+a8vhy5ZbDQ0O3pG4DWsBMUu0wV5145y6EB6oZ+4LXUxrTNoSKAmuvHqGA==", "0edcbff6-3e24-4518-b8e0-e0ef99b4c9af" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e38a22b9-3916-4d90-9460-c13fa486ecf9", "AQAAAAEAACcQAAAAEBq6UwhYMWHg8S0sWkDcaSTlD36zXDsCqGwfxQFf4SB884eWiPF5GkgjquGxcTKhrg==", "4d5e417c-0fde-46e5-bc88-34fd153c23a8" });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "40540fc0-ee18-44e5-932f-fbec03452ca7" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "8226a07a-4dbf-4d5d-94c4-ababa52ea246" },
                    { "8687b07e-038b-43a0-8f6c-40825656e492", "c543626b-1591-4f0c-a1ca-370649ee64e9" },
                    { "8687b07e-038b-43a0-8f6c-40825656e492", "413ad81f-bbb2-41de-89f8-3fd701b2d8d6" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "cbfd0aa8-a64d-438a-85be-4464374e5e73" },
                    { "8687b07e-038b-43a0-8f6c-40825656e492", "d7ea2327-f5cc-4eae-990f-fbd35616ad4f" },
                    { "8687b07e-038b-43a0-8f6c-40825656e492", "c66d3d35-d292-4adb-8412-fcf970f584b6" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "2b618658-c78a-4c0e-8bf2-2f0c1570920e" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "922899af-be3a-4046-9124-eeac5be5d06d" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "658da0b6-b8ad-4a37-ac6e-628581ed3742" },
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "66eaa150-c9b5-4bf3-8ae0-d7bde5e53116" },
                    { "22d2f0de-4b82-4de3-be7f-c1023398fbfe", "37493c5e-e014-4b79-b39e-74e968863127" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "678e5914-dc06-4d15-94fc-bb22c2996a5c" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "d34000ff-a72a-462e-9c37-5cb0405d01f3" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "b2289829-9410-4074-9f99-3e4a93ec19e8" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "0f67950f-e914-4bae-95f8-40c4fd73375c" },
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "7e72cc5f-67f2-4b7c-a69b-29c2b69154cf" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "73b0edc3-9413-4bf4-a1df-70268447264d" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "af354cdd-d715-4937-873a-6680ad908f56" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "4873b3ff-0e1b-4ddb-9600-ac6092ac6c51" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "413442aa-2f9f-4a31-bfec-caa3b4c17c48" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "ed5e7364-9d0f-46ba-8e18-84c0a272e66c" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "0a29137b-8769-4c6c-a7eb-3bf84022a857" },
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "cdd46832-ad85-446b-8e0c-82fa5e2da987" },
                    { "5d05272c-92e5-4012-9b8a-7352ccabb561", "ddbafbfe-fd40-44bd-b338-4825f7946c01" },
                    { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "60555bef-ded6-4b92-83e3-97e8c46f0d71" },
                    { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "c4035cec-6b81-4430-937c-86a0f27312ad" },
                    { "22d2f0de-4b82-4de3-be7f-c1023398fbfe", "960f6e91-244c-4d49-8f55-fdc2bd9a1ee8" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "40540fc0-ee18-44e5-932f-fbec03452ca7", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "40540fc0-ee18-44e5-932f-fbec03452ca7", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" },
                    { "40540fc0-ee18-44e5-932f-fbec03452ca7", "EEBA6608-AB75-4E83-909F-604B1A06F16C" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "b51c5fab-191d-4340-ba6d-409307a82b7d" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "ffa68b47-0100-46b7-ae56-aad0fb5baec5" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "0f66089b-4172-4437-a867-2bb169c58e0f" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSystems",
                keyColumn: "Contact_Id",
                keyValue: "ccf09f19-a11c-497f-9e93-f574fc1f9468");

            migrationBuilder.DeleteData(
                table: "ContactUsers",
                keyColumn: "cu_Id",
                keyValue: "c0c31443-5360-47e0-a28c-0f5a38deedfd");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "77f08e2d-e167-49ef-bb27-beba332a92a3");

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "couponId",
                keyValue: "7ca3df06-5ddc-4be8-bfed-08ad6b74e2a9");

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "0a29137b-8769-4c6c-a7eb-3bf84022a857" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "0f67950f-e914-4bae-95f8-40c4fd73375c" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "2b618658-c78a-4c0e-8bf2-2f0c1570920e" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "22d2f0de-4b82-4de3-be7f-c1023398fbfe", "37493c5e-e014-4b79-b39e-74e968863127" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "40540fc0-ee18-44e5-932f-fbec03452ca7" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "413442aa-2f9f-4a31-bfec-caa3b4c17c48" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "8687b07e-038b-43a0-8f6c-40825656e492", "413ad81f-bbb2-41de-89f8-3fd701b2d8d6" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "4873b3ff-0e1b-4ddb-9600-ac6092ac6c51" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "60555bef-ded6-4b92-83e3-97e8c46f0d71" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "658da0b6-b8ad-4a37-ac6e-628581ed3742" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "66eaa150-c9b5-4bf3-8ae0-d7bde5e53116" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "678e5914-dc06-4d15-94fc-bb22c2996a5c" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "73b0edc3-9413-4bf4-a1df-70268447264d" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "7e72cc5f-67f2-4b7c-a69b-29c2b69154cf" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "8226a07a-4dbf-4d5d-94c4-ababa52ea246" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "922899af-be3a-4046-9124-eeac5be5d06d" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "22d2f0de-4b82-4de3-be7f-c1023398fbfe", "960f6e91-244c-4d49-8f55-fdc2bd9a1ee8" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "af354cdd-d715-4937-873a-6680ad908f56" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "b2289829-9410-4074-9f99-3e4a93ec19e8" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "c4035cec-6b81-4430-937c-86a0f27312ad" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "8687b07e-038b-43a0-8f6c-40825656e492", "c543626b-1591-4f0c-a1ca-370649ee64e9" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "8687b07e-038b-43a0-8f6c-40825656e492", "c66d3d35-d292-4adb-8412-fcf970f584b6" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "747961a5-c868-4f46-aeb0-8e43ec8a4ee7", "cbfd0aa8-a64d-438a-85be-4464374e5e73" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "9867fd9e-0d12-4f4f-b0c9-937c949d29c7", "cdd46832-ad85-446b-8e0c-82fa5e2da987" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "d34000ff-a72a-462e-9c37-5cb0405d01f3" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "8687b07e-038b-43a0-8f6c-40825656e492", "d7ea2327-f5cc-4eae-990f-fbd35616ad4f" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "ddbafbfe-fd40-44bd-b338-4825f7946c01" });

            migrationBuilder.DeleteData(
                table: "ProductsInCategories",
                keyColumns: new[] { "pic_CategoriesId", "pic_productId" },
                keyValues: new object[] { "5d05272c-92e5-4012-9b8a-7352ccabb561", "ed5e7364-9d0f-46ba-8e18-84c0a272e66c" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "40540fc0-ee18-44e5-932f-fbec03452ca7", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "40540fc0-ee18-44e5-932f-fbec03452ca7", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" });

            migrationBuilder.DeleteData(
                table: "ReviewInproduct",
                keyColumns: new[] { "rip_ProductId", "rip_ReviewId" },
                keyValues: new object[] { "40540fc0-ee18-44e5-932f-fbec03452ca7", "EEBA6608-AB75-4E83-909F-604B1A06F16C" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "0f66089b-4172-4437-a867-2bb169c58e0f" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "b51c5fab-191d-4340-ba6d-409307a82b7d" });

            migrationBuilder.DeleteData(
                table: "SubReviewInReview",
                keyColumns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                keyValues: new object[] { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "ffa68b47-0100-46b7-ae56-aad0fb5baec5" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "22d2f0de-4b82-4de3-be7f-c1023398fbfe");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "5d05272c-92e5-4012-9b8a-7352ccabb561");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "747961a5-c868-4f46-aeb0-8e43ec8a4ee7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "8687b07e-038b-43a0-8f6c-40825656e492");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "cg_Id",
                keyValue: "9867fd9e-0d12-4f4f-b0c9-937c949d29c7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0a29137b-8769-4c6c-a7eb-3bf84022a857");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "0f67950f-e914-4bae-95f8-40c4fd73375c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "2b618658-c78a-4c0e-8bf2-2f0c1570920e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "37493c5e-e014-4b79-b39e-74e968863127");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "40540fc0-ee18-44e5-932f-fbec03452ca7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "413442aa-2f9f-4a31-bfec-caa3b4c17c48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "413ad81f-bbb2-41de-89f8-3fd701b2d8d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "4873b3ff-0e1b-4ddb-9600-ac6092ac6c51");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "60555bef-ded6-4b92-83e3-97e8c46f0d71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "658da0b6-b8ad-4a37-ac6e-628581ed3742");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "66eaa150-c9b5-4bf3-8ae0-d7bde5e53116");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "678e5914-dc06-4d15-94fc-bb22c2996a5c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "73b0edc3-9413-4bf4-a1df-70268447264d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "7e72cc5f-67f2-4b7c-a69b-29c2b69154cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "8226a07a-4dbf-4d5d-94c4-ababa52ea246");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "922899af-be3a-4046-9124-eeac5be5d06d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "960f6e91-244c-4d49-8f55-fdc2bd9a1ee8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "af354cdd-d715-4937-873a-6680ad908f56");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "b2289829-9410-4074-9f99-3e4a93ec19e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c4035cec-6b81-4430-937c-86a0f27312ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c543626b-1591-4f0c-a1ca-370649ee64e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "c66d3d35-d292-4adb-8412-fcf970f584b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "cbfd0aa8-a64d-438a-85be-4464374e5e73");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "cdd46832-ad85-446b-8e0c-82fa5e2da987");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d34000ff-a72a-462e-9c37-5cb0405d01f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "d7ea2327-f5cc-4eae-990f-fbd35616ad4f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ddbafbfe-fd40-44bd-b338-4825f7946c01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "pd_Id",
                keyValue: "ed5e7364-9d0f-46ba-8e18-84c0a272e66c");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "0f66089b-4172-4437-a867-2bb169c58e0f");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "b51c5fab-191d-4340-ba6d-409307a82b7d");

            migrationBuilder.DeleteData(
                table: "SubReview",
                keyColumn: "subReview_Id",
                keyValue: "ffa68b47-0100-46b7-ae56-aad0fb5baec5");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "D269BF93-A5E2-4C4A-8146-9967DDE80D30",
                column: "bill_DatetimeOrder",
                value: new DateTime(2022, 4, 29, 23, 54, 33, 648, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "Snack", "", "" },
                    { "71f3d393-3be7-4db9-b8fc-87ceb9c22402", "Banhmi", "", "" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "Dry food", "", "" },
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "Food", "", "" },
                    { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "Drink", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Description", "Contact_Email", "Contact_Phone" },
                values: new object[] { "3b830e26-6123-498c-a73b-9781599a71bd", "Huntsville, AL 35813, USA", "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.", "support@foodshop.com ", "021.343.7575" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { "df8a5675-3d3e-4ec5-b96d-9719ad55d28c", "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "6fea5196-8897-4f26-88f6-6f116afc22b5", "code10", 10 },
                    { "69f9af4a-90b1-4f24-b553-5df615f0fc2e", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "isDelete", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { "4e99358c-883a-4d51-8099-4b15037d65ed", false, "loteria", "/images/item250x300/loteria.png", "", "", "", "loteria", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "24cd3345-f191-410e-861f-9d6c171b79f1", false, "mitronanvat", "/images/item250x300/mitronanvat.png", "", "", "", "mitronanvat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "93b5af59-8956-42cc-b7f4-7a5b8252345b", false, "monngontrangbang", "/images/item250x300/monngontrangbang.png", "", "", "", "monngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "03b02d76-6014-4758-b863-b66dea5a84f2", false, "ParisBaguete", "/images/item250x300/ParisBaguete.png", "", "", "", "ParisBaguete", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "a6f36a54-d0b5-4c8c-b1ea-66621ffa5fb0", false, "pizza", "/images/item250x300/pizza.png", "", "", "", "pizza", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "0e4a08a3-ce67-4bb9-877d-1d7b3ed7de01", false, "Royaltea", "/images/item250x300/Royaltea.png", "", "", "", "Royaltea", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "b21ee332-770d-4e16-9d97-41122a7b6ee1", false, "RauMaMix", "/images/item250x300/RauMaMix.png", "", "", "", "RauMaMix", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "bf492cd5-3553-47fa-b053-74897d89adc0", false, "Sanfulou", "/images/item250x300/Sanfulou.png", "", "", "", "Sanfulou", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f056c48b-1819-4b56-be86-270177cbe16d", false, "stacbuk-cf", "/images/item250x300/stacbuk-cf.png", "", "", "", "stacbuk-cf", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "946cc541-0441-4b77-81e1-b4390397b9d3", false, "trasuanhalam", "/images/item250x300/trasuanhalam.png", "", "", "", "trasuanhalam", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "f149b954-6888-4c6f-a2c8-18046a9f2f8b", false, "Xoixeoba3beo", "/images/item250x300/Xoixeoba3beo.png", "", "", "", "Xoixeoba3beo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "039b9b53-e7ff-435e-ab44-666ca5cb0262", false, "quanngontrangbang", "/images/item250x300/quanngontrangbang.png", "", "", "", "quanngontrangbang", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "70119e6c-eab8-4e49-b187-050f7a7efb49", false, "kfc", "/images/item250x300/kfc.png", "", "", "", "kfc", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c14b3a01-e00b-4182-b385-7f326815ef20", false, "KimBap", "/images/item250x300/KimBap.png", "", "", "", "KimBap", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "eb4dd6a0-3bf2-4c8a-a430-37f720e70f91", false, "denhatthitnuong", "/images/item250x300/denhatthitnuong.png", "", "", "", "denhatthitnuong", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "e25e9bbd-d208-4495-a903-7996da649735", false, "BanhCanhCua", "/images/item250x300/BanhCanhCua.png", "", "", "", "BanhCanhCua", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d5c5a167-3e45-4e57-8f2b-c49d3b1f8aa4", false, "BanhMi", "/images/item250x300/BanhMi.png", "", "", "", "BanhMi", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "d437cfde-c033-4ec9-a8df-d6dcbc34715a", false, "banhuotlongdalat", "/images/item250x300/banhuotlongdalat.png", "", "", "", "banhuotlongdalat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "e70915e3-0814-420b-99df-9376841d5f8d", false, "BoKho", "/images/item250x300/BoKho.png", "", "", "", "BoKho", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "320ee4e4-5a27-4848-83fc-cdc92c139baa", false, "bunbo", "/images/item250x300/bunbo.png", "", "", "", "bunbo", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "219e4f80-4108-488c-8927-d5611b83e07f", false, "banhtrangtron", "/images/item250x300/banhtrangtron.png", "", "", "", "banhtrangtron", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c460d4bc-7341-4a5f-914d-922cff462535", false, "Bunxaochay", "/images/item250x300/Bunxaochay.png", "", "", "", "Bunxaochay", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "c9b32e91-15cd-40d5-85c7-45874c7b4f07", false, "cocosummer", "/images/item250x300/cocosummer.png", "", "", "", "cocosummer", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "3e865ddb-e69d-417a-a517-443ded410dd8", false, "comboxao", "/images/item250x300/comboxao.png", "", "", "", "comboxao", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "69b258a1-b710-425b-ad33-ebc7a7520709", false, "comga", "/images/item250x300/comga.png", "", "", "", "comga", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "198f2c03-15d9-4964-89cc-0f85d19debe6", false, "comgadenhat", "/images/item250x300/comgadenhat.png", "", "", "", "comgadenhat", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "59bdb3d1-f663-49f4-ac4c-a5f1e5a0eac9", false, "bundaumamtom", "/images/item250x300/bundaumamtom.png", "", "", "", "bundaumamtom", "1", "2", "3", "4", 1, 5, 0, "Short Description", false },
                    { "99182378-29a6-442b-83e8-25900b92d4c4", false, "goicuon", "/images/item250x300/goicuon.png", "", "", "", "goicuon", "1", "2", "3", "4", 1, 5, 0, "Short Description", false }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258",
                column: "ConcurrencyStamp",
                value: "b1c374db-6c07-46b4-91b2-aeca78d0ce4e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd",
                column: "ConcurrencyStamp",
                value: "15d63377-8ae9-44ef-94c9-5da8a8ecbd35");

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "2222ff20-ec5e-4bcc-b5d7-173bc5be1a50", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "eb7e82bb-0354-41ca-be00-fcccdc75edd1", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[] { "b606dd1b-dafd-4a0c-bac0-2a7ed50fe172", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3f2677c-2f11-4050-8685-9c65b1cbf936", "AQAAAAEAACcQAAAAENAdBN/JO8iE0BOHOBOLb3+xELc/yux2MXHKQRz+zM5uuzW4E82iuBzfsC7eRX8vNw==", "d9b46af1-fa36-4455-82d9-f8f640bc6e3c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41ab9d0c-9faf-4556-85dd-1939195feb47", "AQAAAAEAACcQAAAAEDJaeGA+Pt/Hz9DFEy6op99rRXl9nQ2AL+V6Q5ae08cJa5W36ugvqb7Nh/UwegNYTg==", "1a5d2efb-17ea-4e70-b6a4-45b62e94f0e0" });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "e25e9bbd-d208-4495-a903-7996da649735" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "f149b954-6888-4c6f-a2c8-18046a9f2f8b" },
                    { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "946cc541-0441-4b77-81e1-b4390397b9d3" },
                    { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "f056c48b-1819-4b56-be86-270177cbe16d" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "bf492cd5-3553-47fa-b053-74897d89adc0" },
                    { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "0e4a08a3-ce67-4bb9-877d-1d7b3ed7de01" },
                    { "e9a2c00e-4fd6-4796-8449-ab7fb63dc416", "b21ee332-770d-4e16-9d97-41122a7b6ee1" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "039b9b53-e7ff-435e-ab44-666ca5cb0262" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "a6f36a54-d0b5-4c8c-b1ea-66621ffa5fb0" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "03b02d76-6014-4758-b863-b66dea5a84f2" },
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "93b5af59-8956-42cc-b7f4-7a5b8252345b" },
                    { "71f3d393-3be7-4db9-b8fc-87ceb9c22402", "24cd3345-f191-410e-861f-9d6c171b79f1" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "4e99358c-883a-4d51-8099-4b15037d65ed" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "c14b3a01-e00b-4182-b385-7f326815ef20" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "70119e6c-eab8-4e49-b187-050f7a7efb49" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "99182378-29a6-442b-83e8-25900b92d4c4" },
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "e70915e3-0814-420b-99df-9376841d5f8d" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "198f2c03-15d9-4964-89cc-0f85d19debe6" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "69b258a1-b710-425b-ad33-ebc7a7520709" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "3e865ddb-e69d-417a-a517-443ded410dd8" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "c9b32e91-15cd-40d5-85c7-45874c7b4f07" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "c460d4bc-7341-4a5f-914d-922cff462535" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "59bdb3d1-f663-49f4-ac4c-a5f1e5a0eac9" },
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "320ee4e4-5a27-4848-83fc-cdc92c139baa" },
                    { "7679dc40-a09a-49de-bc78-e48c28e00384", "eb4dd6a0-3bf2-4c8a-a430-37f720e70f91" },
                    { "d8ab4da3-085e-488d-beec-17795a11f33e", "d437cfde-c033-4ec9-a8df-d6dcbc34715a" },
                    { "fb1bb6f5-6010-496c-a459-bc7968bedd94", "219e4f80-4108-488c-8927-d5611b83e07f" },
                    { "71f3d393-3be7-4db9-b8fc-87ceb9c22402", "d5c5a167-3e45-4e57-8f2b-c49d3b1f8aa4" }
                });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { "e25e9bbd-d208-4495-a903-7996da649735", "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { "e25e9bbd-d208-4495-a903-7996da649735", "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" },
                    { "e25e9bbd-d208-4495-a903-7996da649735", "EEBA6608-AB75-4E83-909F-604B1A06F16C" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "eb7e82bb-0354-41ca-be00-fcccdc75edd1" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "2222ff20-ec5e-4bcc-b5d7-173bc5be1a50" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "b606dd1b-dafd-4a0c-bac0-2a7ed50fe172" }
                });
        }
    }
}
