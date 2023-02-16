using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlertHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "9a13f51b-457c-4d91-9164-ef3fce898c99", "Simple_User", "SIMPLE_USER" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "Civil_Protection", "CIVIL_PROTECTION" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01766675-a912-4f43-92f0-83fb64d9360a", 0, "f8b94711-25f8-4507-9883-d3cfbf8da583", "Saul.Stamm@hotmail.com", false, true, null, "SAUL.STAMM@HOTMAIL.COM", "SAUL.STAMM73", "AQAAAAIAAYagAAAAECGkynG/dgh2pYVqIINmUjPgtPz2JalQ2sDrOu6ocfc11hggpL9BsYUFCGW+rXzcMQ==", null, false, "21534f33-e868-4dba-9ce0-205f4765b042", false, "Saul.Stamm73" },
                    { "03b9bf21-5b8a-4c82-ab97-97f6d65356e9", 0, "53027532-a4e3-477b-9984-8e01a02d53c1", "Sophia_Baumbach@yahoo.com", false, true, null, "SOPHIA_BAUMBACH@YAHOO.COM", "SOPHIA6", "AQAAAAIAAYagAAAAEEJEsJovA7YfZs1WR9DmxB4c2glVqeV757TqTOodWlxP64gUZVN/C8Unh/O8wJwO1Q==", null, false, "c23cda90-23f2-4bc4-a1b1-8dfacad41bc0", false, "Sophia6" },
                    { "0459ef7c-8069-461a-9893-7df5f3fc8e3d", 0, "c2f8f111-25bc-42ac-86bd-ed424d088c05", "Erica.Jones10@gmail.com", false, true, null, "ERICA.JONES10@GMAIL.COM", "ERICA68", "AQAAAAIAAYagAAAAEFeyEVoOYCzFnHueGJar7/1JJwy98tD+1gyy/6CWe/H9Y/SdpGmfAmKqHsNugu7iVw==", null, false, "1984999d-0982-4927-ad00-3a1e485d7c45", false, "Erica68" },
                    { "049e9eb8-b612-4140-8e4b-9382074b0a6f", 0, "cdad6dda-fc4c-43eb-a2d8-3b6bd3459a05", "Nellie.Ruecker94@gmail.com", false, true, null, "NELLIE.RUECKER94@GMAIL.COM", "NELLIE44", "AQAAAAIAAYagAAAAECzVHNs7IPsW3bZkqC3gGwzFzclnc5p4DhVafSoPoVIfq71kAnGjV/pdDbBV8ZVjxw==", null, false, "0f0fd7e2-2e62-42f8-80c0-d2efa20e150f", false, "Nellie44" },
                    { "04a70a68-9bae-4eca-9122-caac546f62a4", 0, "89a8f435-57b2-48a9-b66d-08fdd994a617", "Marlene67@gmail.com", false, true, null, "MARLENE67@GMAIL.COM", "MARLENE23", "AQAAAAIAAYagAAAAEKVjlkugUwNu6SunkAdhZEI5Z87IUV4fxch/BedYWhnfd/UEPwNFSOxwDVQcQIVpSw==", null, false, "4fc2325d-8cdb-447f-ae67-dd5c212fcd14", false, "Marlene23" },
                    { "06827f98-7153-4f4f-995c-f4fefaf59bb6", 0, "9db0839f-55c6-4ca8-b2a6-b10c0a8ffc9a", "Melody.Weber@yahoo.com", false, true, null, "MELODY.WEBER@YAHOO.COM", "MELODY77", "AQAAAAIAAYagAAAAEH9aV+Mlcs7SQzQCVZSwf2ttAK3WW7xQv+F9oLuNYD/szRM4VxoUDOhsCTvvOyiVcQ==", null, false, "fa5fa4ae-4e6f-479a-b3fc-0bffad6ca643", false, "Melody77" },
                    { "08056d72-0447-40e6-ae8e-dc19679c626c", 0, "6f18c89c-c611-4ada-b8b9-4ae42e6beb28", "Alexandra1@hotmail.com", false, true, null, "ALEXANDRA1@HOTMAIL.COM", "ALEXANDRA_HARTMANN1", "AQAAAAIAAYagAAAAEGxZjDdjM3EG9IaQ7GZCoJ1MiPBBKvLR//RUp2MJFVkLI/Z6eR88cjdOJFOOKKgArQ==", null, false, "9969a824-0b0c-46d9-b362-9fec705c38ee", false, "Alexandra_Hartmann1" },
                    { "0a6992b4-3d98-471d-94b7-2a6e9a1d1889", 0, "c7285ea3-00a0-45d8-842a-f1246788bd52", "Bessie_Koelpin20@yahoo.com", false, true, null, "BESSIE_KOELPIN20@YAHOO.COM", "BESSIE_KOELPIN", "AQAAAAIAAYagAAAAEHs2TU+oRfzf2ZEOP2JAzyhcbZ5Pz/kPYy7+1ks2pMBEWGo1BWA+lVfeqX8Rwqnj1w==", null, false, "453172bf-c08e-4b67-a607-566d976e49aa", false, "Bessie_Koelpin" },
                    { "0cdb00ee-31ca-421a-b9a9-accf487be449", 0, "4caa6e36-b37e-42ab-b0dc-f5b63e97d357", "Vincent_Hudson@yahoo.com", false, true, null, "VINCENT_HUDSON@YAHOO.COM", "VINCENT86", "AQAAAAIAAYagAAAAEKETSSl0a2tFZJciAKPl45oLi8ZAEBNYthewqUhloM4CL1+lcEjcrJEsqtY8P3JyvA==", null, false, "f13ea6b6-b9aa-42e4-9e7e-fc5f314e5d93", false, "Vincent86" },
                    { "0d0bf0ce-044f-4464-b1c3-38568f1fb9ef", 0, "39863bf5-a8d8-4a5b-9f68-3ae215f30d5d", "Armando.Abernathy@hotmail.com", false, true, null, "ARMANDO.ABERNATHY@HOTMAIL.COM", "ARMANDO_ABERNATHY0", "AQAAAAIAAYagAAAAENWPHW3XrDrzX18D56z43pcDtzKK1+BUbrhNzmfNDOcDu9UXYzkvVcGc8pnyyF7Fyw==", null, false, "b22939c2-0e27-4edd-9e5c-5ba0f770fad6", false, "Armando_Abernathy0" },
                    { "118ea5a2-f110-427c-8a93-1c742e84e781", 0, "2d3010d9-1abe-44e1-95fc-fe084feca979", "Darla41@hotmail.com", false, true, null, "DARLA41@HOTMAIL.COM", "DARLA.GRANT", "AQAAAAIAAYagAAAAEJ7fUo2/4gl1/XPVay1lZoldtg++UrCEOZPIlLURmYZKAJnnUiJqBCzZJGP4SB/3cg==", null, false, "9df30db7-43b0-4999-b9c5-901852e21872", false, "Darla.Grant" },
                    { "12897c7e-4203-4160-b7bd-5eb2bd7dcffb", 0, "4abb14da-d30a-48f0-96c5-e58273992ce9", "Todd_Lang90@hotmail.com", false, true, null, "TODD_LANG90@HOTMAIL.COM", "TODD_LANG62", "AQAAAAIAAYagAAAAENEwkwtAQA2tqBxOJLvfVnIILbKKYYMrRAJzrYmSpp2FeyknRGXtPL7UVHTdN4Sjrw==", null, false, "6c6b6294-01e1-4dfe-b8a9-f511de4e114a", false, "Todd_Lang62" },
                    { "168369ef-3476-4ebc-b86c-e509ac147514", 0, "5e1a1f25-0893-4ed8-87b8-3576c44562a7", "Cecelia_Medhurst35@yahoo.com", false, true, null, "CECELIA_MEDHURST35@YAHOO.COM", "CECELIA_MEDHURST", "AQAAAAIAAYagAAAAEGVY6se1HROPS4msZL7NsjZpTu4jVa7oIbWqBIO/ZXbGjvqJr5R3KNhhRJJiutqfCA==", null, false, "dbb497b5-d2e5-419d-a87c-6d3bd88ded1f", false, "Cecelia_Medhurst" },
                    { "16ce8387-0c6a-4074-ac75-748ac19b6e65", 0, "74686f7b-829d-4522-85dc-42a59486803b", "Edna99@yahoo.com", false, true, null, "EDNA99@YAHOO.COM", "EDNA_CONNELLY", "AQAAAAIAAYagAAAAEKZOvOjX65yUO/BsckDr0lSY59Ey0yDWYFpq+riFLJwURr/EiFEt6ixKbk1PiXSclQ==", null, false, "128c49a1-ec94-4ae2-b412-2d21d555f02a", false, "Edna_Connelly" },
                    { "1dd0799d-c242-494e-b46a-0e0d8ee56860", 0, "5608c3f4-bac5-4c9e-8077-89412a2d8606", "Larry.Douglas@yahoo.com", false, true, null, "LARRY.DOUGLAS@YAHOO.COM", "LARRY.DOUGLAS56", "AQAAAAIAAYagAAAAECJbQOaaRFS0/rlNl5dOFN3mv/7DxfleYh/Ij/zGyAVmdq2XxgBu3ta1qf8NJdhztg==", null, false, "96a2b592-d7a7-4aa8-81aa-d8b19f9868db", false, "Larry.Douglas56" },
                    { "1dd156ee-acb8-40d4-aa20-e46004c1e1de", 0, "ce49908d-5dd5-4af9-a82e-b649fc7a1e1e", "Betty.Waelchi12@gmail.com", false, true, null, "BETTY.WAELCHI12@GMAIL.COM", "BETTY_WAELCHI", "AQAAAAIAAYagAAAAEKKzq3JMAEEe0PPZX36wGY4bRvs7amykQTKiqPC7Z3AHVQma8DD/+WUXZhxbwfU0xA==", null, false, "a13e7803-e9e0-42f9-bdc3-a53ee2f244c8", false, "Betty_Waelchi" },
                    { "242bf0aa-a17f-4f07-9b1b-725c2398f2a1", 0, "367614e9-a979-4b8e-956c-e7d42f23b0b4", "Allan_Brakus20@yahoo.com", false, true, null, "ALLAN_BRAKUS20@YAHOO.COM", "ALLAN70", "AQAAAAIAAYagAAAAEJUkzkwSdNYlHkniETNLw8IiZC6k3c2ln3BZzqNwHinJ0lBhsPF9jqcVtT1cta0CtA==", null, false, "ae9ceb1b-df4b-4f63-9e14-5370644e58d5", false, "Allan70" },
                    { "2843d530-0182-43ac-a0d9-5ed1dd6751c4", 0, "8af82a5a-f1e7-45d2-a133-60dd94512f9a", "Chelsea_Deckow67@gmail.com", false, true, null, "CHELSEA_DECKOW67@GMAIL.COM", "CHELSEA90", "AQAAAAIAAYagAAAAELvP3YTJPy/y+gPHRHa/ShO1q3+GfkhSy+yJmOcivim0MwwZIrFgFRGDW+/hodfqdg==", null, false, "38340ba0-884d-48d6-89f6-c7ca60dd1943", false, "Chelsea90" },
                    { "2a531804-0713-4881-b672-b823979245ca", 0, "d0b5f53f-e0cc-448a-961b-332871131d60", "Diana_McDermott@hotmail.com", false, true, null, "DIANA_MCDERMOTT@HOTMAIL.COM", "DIANA.MCDERMOTT70", "AQAAAAIAAYagAAAAEP3+IIBgNz8l0Zq/eMhYe+yLfw66W26bIz0bfUL4FLl3zaiMiLxI7bz0N4z09uIWOg==", null, false, "3f9136f3-102c-426a-b488-e623342fe0e2", false, "Diana.McDermott70" },
                    { "2b22e75a-76f7-4137-ac9a-52e7068b08c1", 0, "6657deb1-61f1-42e9-9623-f6c2d18c739c", "Sonja43@yahoo.com", false, true, null, "SONJA43@YAHOO.COM", "SONJA13", "AQAAAAIAAYagAAAAEJkU/bTjk/70vOYXan6w7heBwm1Dd/fhNtQ+phBEqonob2Pl7cFAvjcBBbdI0Cqhdg==", null, false, "9226c15f-f5a8-4856-a645-aa170bd86ede", false, "Sonja13" },
                    { "2d84dd81-4ba7-4cc0-8521-bd2df30ed9ca", 0, "870b6d19-d1ea-475a-a051-767ea36c3066", "Lucia_Legros@yahoo.com", false, true, null, "LUCIA_LEGROS@YAHOO.COM", "LUCIA64", "AQAAAAIAAYagAAAAECV0snv15SZFArFG5TPdVy92wKLKOYXM4f72e6xAZHx4S6txMy5B7E6T7NQTCGK8ig==", null, false, "9befd4ea-680c-46cb-b524-47225e9b4939", false, "Lucia64" },
                    { "2f0edde9-d030-4625-9c28-f45b3d3731ce", 0, "51ddd576-d0c9-4096-b249-ea03b1cdb9c6", "Salvatore21@gmail.com", false, true, null, "SALVATORE21@GMAIL.COM", "SALVATORE.GOLDNER", "AQAAAAIAAYagAAAAELyTlVP5QLB8GvH4net9lih59+6apIsyUJLFe9Ca125fvNRUUGsRUjdBBKagFFMKYA==", null, false, "7b0023f2-c70b-450e-a47a-9d85a9682447", false, "Salvatore.Goldner" },
                    { "2f479edb-55e8-44a2-8da2-5112255a99de", 0, "d3d4fc2b-3cec-4623-86bd-2747bbf6e0af", "Gerardo_Schuster44@gmail.com", false, true, null, "GERARDO_SCHUSTER44@GMAIL.COM", "GERARDO_SCHUSTER37", "AQAAAAIAAYagAAAAEJV3/34qp3MBZFBE8GLUu5VzR6Rse/L/J7X1TimWYzwY36I7+n/Jjk+3Px+BgYH9GQ==", null, false, "ce55459a-61c9-4dd9-8ab5-638d95109052", false, "Gerardo_Schuster37" },
                    { "366616d3-60b9-4eb9-9645-b7a3f25897ee", 0, "9b908c15-42b7-410f-b3d3-6266b57d9225", "Gustavo_Price43@hotmail.com", false, true, null, "GUSTAVO_PRICE43@HOTMAIL.COM", "GUSTAVO_PRICE", "AQAAAAIAAYagAAAAEJ96BCLb5x92q4BwmBRDWqIwsQQBZKBHrQZIK+eln8ZEprrVJvJznd7o4MRH9qEV3g==", null, false, "043d0805-c995-4809-a8e7-7d377e931120", false, "Gustavo_Price" },
                    { "39669ccb-7ea1-406a-93aa-e1d1347f832e", 0, "ef5433de-34ab-413b-880e-cfedee2a748f", "Horace.Erdman@hotmail.com", false, true, null, "HORACE.ERDMAN@HOTMAIL.COM", "HORACE.ERDMAN14", "AQAAAAIAAYagAAAAEOfO/WyfS8OfTSwCvMb7LcToav0edO1aPPw/hlba1T3NiCIoFVAouyia1M6PbYxROw==", null, false, "5d4efa92-a16d-451b-bd4c-d228ca691ab8", false, "Horace.Erdman14" },
                    { "3b0a65c2-11dc-4ee4-9e1b-66808f9b06ce", 0, "e5720c4c-d9ec-41e6-86f1-273d6b91ab5e", "Kathryn53@hotmail.com", false, true, null, "KATHRYN53@HOTMAIL.COM", "KATHRYN_MCCULLOUGH", "AQAAAAIAAYagAAAAEJiVs78YWmRYbAxx8TZAfv/jeabLwOlUKCzg6zBFdjlxKtNqEpUdaed73pypFSHyCg==", null, false, "381fff0a-34f8-405b-b377-03763854ff0b", false, "Kathryn_McCullough" },
                    { "3b318fb2-4ef7-43aa-9d19-4730046e9c6d", 0, "d9df4be5-1562-4aef-945e-0cde1b7507e9", "Martin21@hotmail.com", false, true, null, "MARTIN21@HOTMAIL.COM", "MARTIN.SCHROEDER", "AQAAAAIAAYagAAAAEK5/2hWRfvGNdJ0eX+t0B3Gq311CTVA7a28lNpJFSOCjkrtaRJs+sEfUErX3cFoFhw==", null, false, "9fbf8960-54b6-41dd-b310-9e1d5d333709", false, "Martin.Schroeder" },
                    { "3ec7c3b0-ff85-4dae-9428-e9629d60b62e", 0, "a746471e-95ba-4320-9de7-bfb24e7c07bc", "Pauline.Wunsch31@gmail.com", false, true, null, "PAULINE.WUNSCH31@GMAIL.COM", "PAULINE.WUNSCH", "AQAAAAIAAYagAAAAEMHjDutZi6SMGYZ3aZR5sVwxX5E06OgVyZVJX3Y5JN+VlSmNX6W83acMBc9cbYXB9w==", null, false, "ae06493c-cfef-470a-865a-f1ace51a1fb9", false, "Pauline.Wunsch" },
                    { "3feb375c-09ee-4c01-a906-591a37957729", 0, "d64d9254-e2f7-4089-95e8-3ac239684fb5", "Stuart.Boehm10@yahoo.com", false, true, null, "STUART.BOEHM10@YAHOO.COM", "STUART93", "AQAAAAIAAYagAAAAEFCWDWd+5ylIUsgtUoeGl7xzXs7WexkeIWLm5tRWLVuqt62cm9tZmLODaLEt6Ru/Ew==", null, false, "73c81326-bbf0-4277-baea-8bdd23debb0a", false, "Stuart93" },
                    { "439a1d11-b992-4489-9eb5-2937ea05a9a5", 0, "ca5030da-f544-4efc-972a-8b98ece24ee4", "Lindsay.Hettinger86@yahoo.com", false, true, null, "LINDSAY.HETTINGER86@YAHOO.COM", "LINDSAY_HETTINGER", "AQAAAAIAAYagAAAAEA/sB+Q8psC0Dgw8tOIZfVuwpqWYXBwfmF8z69TrdRO1JC7KGrWUjRtgtgPTgourAA==", null, false, "2c1bc080-9f29-4ae1-a1fa-b0a6e8e386d8", false, "Lindsay_Hettinger" },
                    { "43b40e27-555f-46cc-bcfb-9599eb0e637b", 0, "9ec6b1dc-02f9-46d4-a252-290d54f33681", "Lola40@hotmail.com", false, true, null, "LOLA40@HOTMAIL.COM", "LOLA.DAVIS42", "AQAAAAIAAYagAAAAENYnFjUaPOOrWJG8lZ57uXEyvBnU0ZCqus2HLT5Eo3RJo6SGeBghWONV7svl2pyhTA==", null, false, "2e0d5d02-d42e-408c-9512-df5c1f322028", false, "Lola.Davis42" },
                    { "44b4b0ad-fceb-4829-b618-c000ac9730b3", 0, "feed319a-d6ef-4320-bd8e-81fb5b199c57", "Sean_Berge@yahoo.com", false, true, null, "SEAN_BERGE@YAHOO.COM", "SEAN.BERGE", "AQAAAAIAAYagAAAAENFFjJwxEqyLOfOkC0R1fzILng87G6nViD/9tonWMjgIt6GofIo7wu6ez87X3udsdA==", null, false, "a7abb7f0-fea7-4aa7-986c-953b45824482", false, "Sean.Berge" },
                    { "477bdbd0-2eb8-4440-ab2b-8c8bbef1a4a6", 0, "cd30f876-edfd-4c96-860d-2c8f21b0332f", "Wesley.Aufderhar74@hotmail.com", false, true, null, "WESLEY.AUFDERHAR74@HOTMAIL.COM", "WESLEY_AUFDERHAR59", "AQAAAAIAAYagAAAAEAl5nKGHQ5qKFnBgosGjygCq0N824nq92Rl7fuZqt8p7L++GarsGR8ybtIcfenFVjg==", null, false, "2fbea9b5-f0e0-4ec5-b4de-11d04a223f6e", false, "Wesley_Aufderhar59" },
                    { "4793d21c-ffc3-4dc8-9318-43370340bad7", 0, "a1957c1c-e612-437e-8a26-2756169b6de4", "Walter.Price@hotmail.com", false, true, null, "WALTER.PRICE@HOTMAIL.COM", "WALTER.PRICE83", "AQAAAAIAAYagAAAAEH7GR40q6GnjruJGJfFwYgITElvgOTWW9+1vZqSfWcjM227BuJPhiyEwm6AkpcEQ+g==", null, false, "81a6fc60-9778-4191-b3a2-4bfc656437f7", false, "Walter.Price83" },
                    { "4b991469-5cea-4dee-8ace-98a4e19f1085", 0, "7e06285b-9fc5-4714-8350-64c6f873ed91", "Bill.Gulgowski@yahoo.com", false, true, null, "BILL.GULGOWSKI@YAHOO.COM", "BILL_GULGOWSKI", "AQAAAAIAAYagAAAAEIhauHiRtceQlDJnJWxzj5Ipx6P93pi2hFzPvpeC4x5BQc9ZxOntYt31b7Zda1jHmA==", null, false, "0f3f2164-b25a-4e22-8d83-2bef95e6fb3f", false, "Bill_Gulgowski" },
                    { "4e027cc9-1c7f-4191-b8c9-e65efdb9fbad", 0, "c8ce666e-e43e-4fef-ad5b-58ce74ef6062", "Kristen_Thiel31@hotmail.com", false, true, null, "KRISTEN_THIEL31@HOTMAIL.COM", "KRISTEN.THIEL90", "AQAAAAIAAYagAAAAECp3HiPMAHg3DUo2fCjIIWMDhc/ieR8KmePKdKzwKWSsZdtFw06RjolXcUIpEfO6EQ==", null, false, "aa0b72e8-0445-4b19-b164-52efff287304", false, "Kristen.Thiel90" },
                    { "4f8e9bdf-1f6f-4e97-a308-fc4d5e29fdae", 0, "b240c315-f1dd-442c-b385-6301e2b44877", "Mary.Ondricka@gmail.com", false, true, null, "MARY.ONDRICKA@GMAIL.COM", "MARY86", "AQAAAAIAAYagAAAAEIwjZ+6C8SCg7uYIDGb1WEMj/Q77mJpZbeVXP0B53+COsyEd121nlMfdLR61Ff8C0g==", null, false, "63185f27-1cf0-415b-ad27-9abf0b76b9aa", false, "Mary86" },
                    { "57462865-b8a8-462a-b13b-25ba231066b6", 0, "69c5361c-35a6-45da-9129-6dd6570c8a18", "Roy40@yahoo.com", false, true, null, "ROY40@YAHOO.COM", "ROY44", "AQAAAAIAAYagAAAAEJed6M0zX9DPKjfFEGN/2M0Kg7lPTIhzpB0Ak55/WNY4aDinfumaixBkX/6lXbXdRw==", null, false, "75842b0e-9ba2-44f7-82f0-05f85e6cbdd1", false, "Roy44" },
                    { "583221dc-b51a-4c78-bcc8-26d776fcbd35", 0, "fb9d9a70-e00e-4ab8-ba3d-c722167b3e3f", "Jan_Rolfson58@gmail.com", false, true, null, "JAN_ROLFSON58@GMAIL.COM", "JAN66", "AQAAAAIAAYagAAAAECUejPjGSce9i1jUl/ah7GEEpH6BT7AqBOdYLs+Sum26JX35BXUDUBODtLjs5Sat5w==", null, false, "7afdf650-9ecd-4367-af1b-a5e65a5ba0c8", false, "Jan66" },
                    { "5bc0afa6-2239-4e16-81ec-50ce4cbc3f2e", 0, "c78ea66b-51f3-4e55-bb47-37dbe2147c66", "Marcia.Grimes@yahoo.com", false, true, null, "MARCIA.GRIMES@YAHOO.COM", "MARCIA35", "AQAAAAIAAYagAAAAECqCOpTNMglO2RvNEnmTuRvIWQm43xz65uITq5cxMVqMyeH1IoYkRNpd5OMqpxzORg==", null, false, "e0ec6f53-bcfc-4feb-a374-66b51e7e904a", false, "Marcia35" },
                    { "5d84d6a7-bb5a-414c-86e8-4bed157f452e", 0, "44392406-42b7-4763-9600-478d68372c3e", "Emily93@hotmail.com", false, true, null, "EMILY93@HOTMAIL.COM", "EMILY.SCHAMBERGER", "AQAAAAIAAYagAAAAEB2fO7pDrrmaIcEyVZLFg+XMktHxpc+9w5iAk5PY88M6doRI7sqJeW55m9n2KZ6iYg==", null, false, "d4c9de01-0a62-49c2-a087-6c3ac4b1eca3", false, "Emily.Schamberger" },
                    { "5f90f56d-7aa5-4cc0-9c55-ab1f610e917a", 0, "156ab323-e7c4-4c7d-b755-4eff58568ca0", "Herman70@yahoo.com", false, true, null, "HERMAN70@YAHOO.COM", "HERMAN_AUFDERHAR", "AQAAAAIAAYagAAAAEIwQlLL5rRD9IBDBVw3c58xLUoQagkis1aaNO5UAubqTqyHDRhor9+tcHozIODULpQ==", null, false, "7b0b5705-9b5b-4f4e-a091-ca8c93c6e633", false, "Herman_Aufderhar" },
                    { "60b4e72a-66bb-4a91-9cef-f871375e6281", 0, "cd15c491-6e40-425b-8fb0-44f303f31a3c", "Alfred75@hotmail.com", false, true, null, "ALFRED75@HOTMAIL.COM", "ALFRED73", "AQAAAAIAAYagAAAAEBRIsAuV3S/TWHVBnRKF2B3AXNZy3cn4mZQbCMwxBleEuuyQWQmmNMSxNVROvZem5w==", null, false, "355f07e6-42d0-441e-9ee5-27774597d535", false, "Alfred73" },
                    { "62a3d59d-2050-4cae-beb0-9cb3a9db6609", 0, "4cc05556-6344-4004-95bc-f83353ff7485", "Dominick_Moore@yahoo.com", false, true, null, "DOMINICK_MOORE@YAHOO.COM", "DOMINICK_MOORE53", "AQAAAAIAAYagAAAAEDxSRIhMCFklWRtWvTHfKWWL2fizGY05MOFY4XblMPjBAB5N/V8dbuqj4Cu5IjmAzw==", null, false, "9ed66916-c412-4640-af9d-fb65e9a6ce9c", false, "Dominick_Moore53" },
                    { "62ed6a0d-1d38-4fdd-9b4d-0742d8d74e6f", 0, "8d1921d3-ebbe-40ce-81a1-44558c005527", "Roland52@hotmail.com", false, true, null, "ROLAND52@HOTMAIL.COM", "ROLAND_BAUMBACH26", "AQAAAAIAAYagAAAAEA2iygsO9YP9N2zpJjWPOTCKK6mSED5NWuwhTVe9uKCX3TKzZJNs87wg6bOe3BHc2g==", null, false, "fbdb62ad-5c51-4425-9434-fe20a9be099e", false, "Roland_Baumbach26" },
                    { "64d26882-a877-482a-a991-7cfb39b2f778", 0, "3bc93df0-a88e-4632-a1eb-f6a4d70a69f5", "Eva.Witting34@gmail.com", false, true, null, "EVA.WITTING34@GMAIL.COM", "EVA_WITTING33", "AQAAAAIAAYagAAAAEBrEwMzBU5Hu21qcdY4/t+texRF2dLoTd09lVop7XRZNYA5POZrxGErhP6rJeQi6Hg==", null, false, "2178f59b-327b-4231-840c-7dbd0b4fefc6", false, "Eva_Witting33" },
                    { "6bad754d-5278-4ff4-9edc-eec5582ae45b", 0, "ca188018-752b-4e9b-b4ea-7887d5046a11", "Matthew67@hotmail.com", false, true, null, "MATTHEW67@HOTMAIL.COM", "MATTHEW_SCHOEN27", "AQAAAAIAAYagAAAAEIDGYBy3Zy49wP3sTs7gIQjU9ZpAjXJo+6qfDEO4vUOIjWfF7Ih+CRe/vdx/QNpfnw==", null, false, "1fe3f8d4-6ec8-4ccd-a6fe-eb9cb0fc0569", false, "Matthew_Schoen27" },
                    { "727a24a3-edfb-4d30-a235-4333ce4218e3", 0, "a9ad55dc-0dc3-4710-af0e-63e2aeb2c734", "Ana46@gmail.com", false, true, null, "ANA46@GMAIL.COM", "ANA.REMPEL3", "AQAAAAIAAYagAAAAEJCNHDAvHjsr8Q6o1IAFXBUIF4STAe0Ogirx7+by26/CmRNG2gRt2fH1+thJdSQr3w==", null, false, "fc809788-cbd8-4717-a62b-1c5532e0bae6", false, "Ana.Rempel3" },
                    { "735a8878-d946-4cea-8b66-9689378adc35", 0, "e76de651-2892-42f7-9dd8-9a18d24da502", "Isaac55@yahoo.com", false, true, null, "ISAAC55@YAHOO.COM", "ISAAC.SCHINNER17", "AQAAAAIAAYagAAAAEI7ViZL8d/U1dSKzuWB3cyJwkw3jIsINoNLp/xDI2tCg0fomOAFxVM4Qifn2QYockA==", null, false, "128e8750-952c-48fc-a09e-ff6ce103a8d4", false, "Isaac.Schinner17" },
                    { "749e6c3e-79e4-40fc-bc65-2cc32970bb12", 0, "f467cfd6-4d50-4d78-9ca0-c410cce1a633", "Lynn88@gmail.com", false, true, null, "LYNN88@GMAIL.COM", "LYNN.COLE", "AQAAAAIAAYagAAAAEGvfd4JF9SXHmn8vCbUzyyGmjb7L66rxLmUdLuO9bocojpOZvuagQ6TIbb10s52MNA==", null, false, "1cbbf90c-7b9d-40aa-90a2-a4ae3976a5cc", false, "Lynn.Cole" },
                    { "75d801f0-4c1a-4ec4-a7a0-59b1f979f66a", 0, "5ad2cf16-b67f-445c-adce-1c50210fe148", "Andrea.Tromp99@gmail.com", false, true, null, "ANDREA.TROMP99@GMAIL.COM", "ANDREA.TROMP", "AQAAAAIAAYagAAAAEKbj4kDBqscoSP7UgoRR1BBfyWH7KeWu/uzbWf09Oz2wVwZZTHSEHLDJCeZ6Obolaw==", null, false, "34345b70-b907-423a-b317-f8aa2f2a25b9", false, "Andrea.Tromp" },
                    { "7638d278-0874-4d7c-a9eb-648c8000453c", 0, "1df71012-88ce-47a7-8967-bcc2953b86ee", "Nettie73@gmail.com", false, true, null, "NETTIE73@GMAIL.COM", "NETTIE18", "AQAAAAIAAYagAAAAEAaqwZYHmJMqRJno1opyiCtXOsYN+46ucC0LB++cztA8P4UIUiJe6UkQ9gryfi7aLQ==", null, false, "9ffd2a52-ea6d-4d1c-886d-2cd813c5594f", false, "Nettie18" },
                    { "7667b7af-e2d3-486d-a1f7-6ed9638d4153", 0, "1e089dec-633f-44bf-8693-4898466442c5", "Aaron_Wolff84@hotmail.com", false, true, null, "AARON_WOLFF84@HOTMAIL.COM", "AARON_WOLFF", "AQAAAAIAAYagAAAAEP+EcV9l2EEVm4ckfzQDgX6HbGskn8HAyvwT6oJ8PTdm0BJkVgCn/t05djJOPNyeBQ==", null, false, "412298d3-6e1e-4fff-b786-c3713f77dcfd", false, "Aaron_Wolff" },
                    { "7b4d1a63-1683-4b90-8104-071ea7abb606", 0, "e092556e-8fcc-42f3-aed5-539aa4f0f84f", "Sidney29@yahoo.com", false, true, null, "SIDNEY29@YAHOO.COM", "SIDNEY.TURCOTTE", "AQAAAAIAAYagAAAAEOF92qKv3nZxdB4m+QSyGYE2jKFS9CzrOQw8LLVRTL+ant/fdFXeEETMDeq4WdREvw==", null, false, "7617b9f8-f708-4a46-8b59-60f32b50e58a", false, "Sidney.Turcotte" },
                    { "89303085-7a2b-49c0-835d-eef31ce61354", 0, "2bfecf60-0976-431f-8ccd-4c2e9a9f8431", "Oscar_Dietrich50@gmail.com", false, true, null, "OSCAR_DIETRICH50@GMAIL.COM", "OSCAR_DIETRICH27", "AQAAAAIAAYagAAAAEKEs5eLv7gqftB9vTVXXdQlC539Nb3/HqRd27/+RGwsnxIG2exw+0/uRyZ9dIxlPGQ==", null, false, "fccf7494-f46c-4d20-b2ac-e3150812d69b", false, "Oscar_Dietrich27" },
                    { "895d46f5-3059-4064-b091-46466450cd38", 0, "b79775cf-e375-4e90-a237-f0a706a6c94a", "Ken65@gmail.com", false, true, null, "KEN65@GMAIL.COM", "KEN.REINGER", "AQAAAAIAAYagAAAAECr8ADQrOfGUCSb4X08HDcxTMkwd4veUnCyv/01pSylxNI3bRqiEb+9Lj0WnGTGLfQ==", null, false, "81ac93ac-91e3-4017-8789-eca264437268", false, "Ken.Reinger" },
                    { "8b4580e9-c4cc-44ea-9210-65dda58b07a8", 0, "47022d1f-dbd0-451d-96f5-67930a66abcb", "Eugene29@gmail.com", false, true, null, "EUGENE29@GMAIL.COM", "EUGENE_HOPPE", "AQAAAAIAAYagAAAAEFkFLgLnESmxqKS53V5ufNo/Ha6QaRNSL3r2NCRhNlgOBdELfjFA+hX4jZ0yZb24kA==", null, false, "922d4da3-5370-49e0-ac88-73764d352206", false, "Eugene_Hoppe" },
                    { "8bfca591-2828-4e77-81d2-7e6d4fe2e29e", 0, "bea76d1f-8f28-4fc7-b81d-f5b2cde9dd37", "Kimberly.Fisher78@yahoo.com", false, true, null, "KIMBERLY.FISHER78@YAHOO.COM", "KIMBERLY.FISHER", "AQAAAAIAAYagAAAAEJATMjEz1KZl9CxOe9mwmD/7H9zs0g87/NjzQKR9mgch0iEbmnPnSHQU5K5hW28abA==", null, false, "1ca1ce95-510b-4de3-8a95-a3b3aff85241", false, "Kimberly.Fisher" },
                    { "8ec7b2b1-a845-40ec-a0ac-2ff4065793ea", 0, "6e781476-1e56-4040-9e12-9e60640845fe", "Scott_Larson@yahoo.com", false, true, null, "SCOTT_LARSON@YAHOO.COM", "SCOTT_LARSON8", "AQAAAAIAAYagAAAAEJdROTgk761+gA7WglXeUv2bipmWvw8hPfO8pbdJ1COG5+HMxfmzfODOTK4KxPKEPQ==", null, false, "21f85d5b-344c-48bf-976e-5d4b1bad49bf", false, "Scott_Larson8" },
                    { "99afc2f9-00e7-4ec4-b06b-f6993f7c7051", 0, "621f8765-9a19-4619-a4cc-89c46ed4e162", "Dewey_Russel@hotmail.com", false, true, null, "DEWEY_RUSSEL@HOTMAIL.COM", "DEWEY.RUSSEL", "AQAAAAIAAYagAAAAEOjfJx1Y6HeWP7YdmFqyk/+dJySDgl3WsHNby4pwR+HvDSsm9E84+uKdBkpUbs0C9g==", null, false, "d71603f8-eae2-4cd4-92a7-d3e26f83db04", false, "Dewey.Russel" },
                    { "9c09edea-c9fa-4260-9517-1f793ab2ca2a", 0, "3788cf10-2df2-4521-8d3a-6f7b6d702f4d", "Nelson.Buckridge@yahoo.com", false, true, null, "NELSON.BUCKRIDGE@YAHOO.COM", "NELSON.BUCKRIDGE1", "AQAAAAIAAYagAAAAEJryC5DcReAw7SIBB1Ib+iJ0gQJmbr8EiBwJOwxrF9O3DC0GFITZjhcA0p9y9KR1DA==", null, false, "346971b6-fcbb-4eef-b43a-17e9efa368b5", false, "Nelson.Buckridge1" },
                    { "9ca8885c-c056-44d7-beda-eb8297d86d10", 0, "3894a426-023c-49a3-8472-41b5547948ac", "Marianne_Rutherford@gmail.com", false, true, null, "MARIANNE_RUTHERFORD@GMAIL.COM", "MARIANNE91", "AQAAAAIAAYagAAAAELc/V/7mcqGmmfkGOn/J1S5aHCfgePQl7Aru2FdJH+Oy4fYxCjsUp4KFNJQ7QyUpJA==", null, false, "92463ace-bfef-4d0e-a39b-1a4134ef3fd6", false, "Marianne91" },
                    { "a00b9d22-e2f7-402b-974f-dd2e927df0df", 0, "29a85286-f0d1-49e1-ad4a-a417a8727130", "Terrance.Schmitt33@yahoo.com", false, true, null, "TERRANCE.SCHMITT33@YAHOO.COM", "TERRANCE69", "AQAAAAIAAYagAAAAEAZgOcRHKg4CKmxk/d0FSvUjKs9Od9KANwBTd5T8JzgA85KgKx3YXPRBoW1rIhBV8w==", null, false, "4f3e04cd-fdfd-4857-badd-da41faaac2d4", false, "Terrance69" },
                    { "a0b1b6dd-fb6e-49bf-a382-e649549103c8", 0, "fe5023cf-c0fe-481b-8868-12b65e3c93fc", "Samuel.Farrell@yahoo.com", false, true, null, "SAMUEL.FARRELL@YAHOO.COM", "SAMUEL55", "AQAAAAIAAYagAAAAEEAc+z28XwD7Yc7NApe55z2GKlKXINNritG+Q+mXx2RUGuZvVfaTVp0IQxb+DQgqqw==", null, false, "8851adfe-93f0-4acf-b406-04b249cd1b7e", false, "Samuel55" },
                    { "a1769368-0488-4930-8cd8-98d0d24b7f89", 0, "e5659710-0679-42ba-82ff-e48894f540c2", "Tiffany_Kunde80@gmail.com", false, true, null, "TIFFANY_KUNDE80@GMAIL.COM", "TIFFANY.KUNDE", "AQAAAAIAAYagAAAAEFLlU8rAb3+uRgTKSq+HoiQQ7OBCwBSRD+5dxAFPe3nzv0HfxSYPIe7Uu+YWEtlxew==", null, false, "21c50424-4b6d-4209-962f-0b15ace44616", false, "Tiffany.Kunde" },
                    { "a463542a-e2db-493b-bed0-85e93b7f830b", 0, "c97f9cf9-4fba-4bf5-b399-dbec31459c97", "Ida.Herman47@yahoo.com", false, true, null, "IDA.HERMAN47@YAHOO.COM", "IDA_HERMAN2", "AQAAAAIAAYagAAAAEAqx66HY8l+v77yqpoyfrfmwpjmTFehPzWHJDBT8f6IRWO1EYgXtbu1Zmk/rxsdoxA==", null, false, "399e437c-174d-4026-b07c-1037461fa2fc", false, "Ida_Herman2" },
                    { "a4e42453-e20c-44a8-8a7e-06802eb5d15e", 0, "721c9eca-0b23-4c51-80a3-89f39d228889", "Diane_Rippin@gmail.com", false, true, null, "DIANE_RIPPIN@GMAIL.COM", "DIANE20", "AQAAAAIAAYagAAAAEIEgz7glewhecmGBCCeXqCBChdh2jQiP4lkvXoTkhQi4NmxRzgN2v2sY7G/cRea8aQ==", null, false, "a4015b03-2bec-406f-a6ac-1baa29f79891", false, "Diane20" },
                    { "a54c935c-d6b5-4f19-adfe-b0e335b60ac7", 0, "ef489908-9221-4e4b-bee3-934bf655a715", "Doris.Powlowski@gmail.com", false, true, null, "DORIS.POWLOWSKI@GMAIL.COM", "DORIS81", "AQAAAAIAAYagAAAAEE2pusY9GYawYZDYdLOyMr5NUJW6Zy7YlwbVy8Iy7a/QdN5LDEVlBPyX9gOP4ZTdeA==", null, false, "a0b73f4a-2761-4de3-aac0-dfeb5c5e5201", false, "Doris81" },
                    { "a54f09d3-570e-4afc-af52-1069253e7734", 0, "1675fc38-685c-4910-b6ef-fefe8de2bf35", "Jared_Wolff72@yahoo.com", false, true, null, "JARED_WOLFF72@YAHOO.COM", "JARED_WOLFF", "AQAAAAIAAYagAAAAEP7AQkzlQFKNLjj8mSwAt5pnJHYVd0DYnX/mUp1R3quXS+RXByiFF96r93to4AT9xA==", null, false, "f3f6260b-3748-421a-bd43-42571f92056f", false, "Jared_Wolff" },
                    { "a7a8e9c6-773a-48b6-a3dc-34fa0090e0c3", 0, "9949ecf0-0bfa-4b9d-b7d9-89d939e75015", "Cora_Homenick86@hotmail.com", false, true, null, "CORA_HOMENICK86@HOTMAIL.COM", "CORA.HOMENICK43", "AQAAAAIAAYagAAAAECrT6eV16XRX+R/1sAF+e3nX0a6NuCFFWMsU2htNX3FBQ51Avse2sl1iYlsIYmsUuQ==", null, false, "1f18140d-f7ec-4c70-976b-4d6d22d54c9d", false, "Cora.Homenick43" },
                    { "a842a0c1-eb9b-41ff-87d8-aa267d08ecdd", 0, "51820e7a-366f-4b6a-bb0f-f8f13427219f", "Mercedes59@yahoo.com", false, true, null, "MERCEDES59@YAHOO.COM", "MERCEDES46", "AQAAAAIAAYagAAAAEBljPJyPwo7GxAMF8281zwPXauTWiECdpTeLzOE6+kIn73CqaliIHa3njvb1bAUVGQ==", null, false, "cdf502a4-2446-4a76-9fd8-bb28f41b6b9e", false, "Mercedes46" },
                    { "a925cd0a-0212-430e-a099-0f3d82334494", 0, "943333ea-2775-4acb-95f9-b89149a90d24", "Jeannette.Murray@hotmail.com", false, true, null, "JEANNETTE.MURRAY@HOTMAIL.COM", "JEANNETTE_MURRAY", "AQAAAAIAAYagAAAAEOgvoAkaMJy55vlnvy6gKyDYvOKUAmGs4smp73JKY9IiL4Hj0n2vMH7r6QQMqdKxXg==", null, false, "2030aa2a-fd8a-40ea-baf3-c9098f83afb3", false, "Jeannette_Murray" },
                    { "acdb748b-10b5-45d6-adfd-3a4a90905584", 0, "0fb7bfc9-02aa-48bf-9a73-16dcc880fcd2", "Velma.Witting@gmail.com", false, true, null, "VELMA.WITTING@GMAIL.COM", "VELMA73", "AQAAAAIAAYagAAAAENaR1s7OEjZsohJUOnf5HCWOTmY/x4iUQVLfQiVInT/rqcHjkDxa3jx9j5BpMHCvsA==", null, false, "311c7120-90b6-4a79-806c-827292f8d17d", false, "Velma73" },
                    { "aef9dc5d-df7a-40b7-94ba-c1e7c3b3ff0e", 0, "e0163650-1c9c-4cad-a425-aaa2551952e1", "Muriel.Jacobs@gmail.com", false, true, null, "MURIEL.JACOBS@GMAIL.COM", "MURIEL37", "AQAAAAIAAYagAAAAELPRg/47qAzfW+Ks6WJUN/8W2l1vIfSS0oXOMTjKDXxmXUtNzArU0YvzJ2P7ClHJLQ==", null, false, "b9ba45b5-6cd0-4ca4-98cd-b59718e8efc5", false, "Muriel37" },
                    { "b0c2d9b3-24da-4830-b49e-64006ab57805", 0, "9cb4f61e-b736-49d2-ad62-153dc6940a70", "David11@gmail.com", false, true, null, "DAVID11@GMAIL.COM", "DAVID.LAKIN", "AQAAAAIAAYagAAAAENuOK6w52LjzKotLq+zddzdkzkY80dDH00drOlWeLcdH5ZKy1tufjlNnjGNhglvhsQ==", null, false, "0d629722-9c32-4693-af92-72a209bf0b07", false, "David.Lakin" },
                    { "b9f6657c-d133-44b3-ac8e-1667572cd437", 0, "fa9ad081-b1f0-4023-955b-c3d6acafc6e4", "Melvin.Volkman61@gmail.com", false, true, null, "MELVIN.VOLKMAN61@GMAIL.COM", "MELVIN_VOLKMAN51", "AQAAAAIAAYagAAAAEBcWvKlumJo5Z8iU0KVkni7HIFdArHBTtLAztLniRnk2mOb7+zzX/ReTkuQ4d7NhSw==", null, false, "98c82a5c-a95c-4d4d-88de-9a8f73b491ac", false, "Melvin_Volkman51" },
                    { "bbc85c75-fe0f-4cac-91dc-133ecc2c32d4", 0, "a4ab2f16-bb2d-4be3-bf1b-a828cd9e6346", "Lori.Boehm68@yahoo.com", false, true, null, "LORI.BOEHM68@YAHOO.COM", "LORI6", "AQAAAAIAAYagAAAAEJxNUp3VWn1q9gSGINr9GuRMU5O+MJfvzEAvmpz+qwop8gm6eEankePdWxu0ylO1ww==", null, false, "11329856-1f25-400b-bdf7-3093360bf8fb", false, "Lori6" },
                    { "c0c439ed-1002-455e-8ccd-06ad397c8972", 0, "226ef43b-81dc-4e16-8086-42ac9225af4d", "Henry.Spinka55@gmail.com", false, true, null, "HENRY.SPINKA55@GMAIL.COM", "HENRY20", "AQAAAAIAAYagAAAAEI5TleXfm55DAlzzxIkD0ZK0tWMSEfYYfCYBc/NKQw2qyvGJTrZwgyR7EmdPf5AD5g==", null, false, "d9054560-0a87-40f2-95f7-15a3dabb505b", false, "Henry20" },
                    { "c31ebb00-2da6-4117-b001-b5eaa58c906d", 0, "567e7b10-87d3-4074-b107-0d240da23ce4", "Rufus_Dach@hotmail.com", false, true, null, "RUFUS_DACH@HOTMAIL.COM", "RUFUS.DACH83", "AQAAAAIAAYagAAAAEJZSykzh4O4FUm/kqxyDQ/FotGF5qcuNi/Y4DRhETSkA0zClzCaozxo12qfyVGxoVQ==", null, false, "6a925894-f3bf-4656-8e3c-9582823c38fc", false, "Rufus.Dach83" },
                    { "ca51e6af-dde5-4d7a-98b1-258a4cc4bb57", 0, "8fa2366d-ab0f-40b7-b31a-e2f76a947029", "Constance.Hermann@gmail.com", false, true, null, "CONSTANCE.HERMANN@GMAIL.COM", "CONSTANCE.HERMANN", "AQAAAAIAAYagAAAAEJ/A1zZkV4+ZH4OPLZZRMnP8Y6HunlSrbJv5IcXkRlL6fMptAIpGD06WXnPtvhPBTA==", null, false, "7c254cd1-aa85-4ae4-a100-0e41cd0c89e3", false, "Constance.Hermann" },
                    { "cb562c30-ec91-4451-902b-94b96f1b05e3", 0, "8238666e-8013-435f-8e7c-9cef5872911e", "Susie81@gmail.com", false, true, null, "SUSIE81@GMAIL.COM", "SUSIE_SCHUMM", "AQAAAAIAAYagAAAAEPGbyup0ykPQ/exzdzRx0m3gervMSkiEwQVwAVVnHJqUQVSHrhSedBfMeLwS0Quc0w==", null, false, "c4879ef0-622d-464a-97f8-2cfddf6157ca", false, "Susie_Schumm" },
                    { "cd7ba642-40ff-4341-ba00-98734ac4d359", 0, "e9a26386-3ec4-4fad-add3-e905aaa7cb25", "Mattie_Nienow@yahoo.com", false, true, null, "MATTIE_NIENOW@YAHOO.COM", "MATTIE.NIENOW", "AQAAAAIAAYagAAAAEM03afdNVMejxAW6n3JuYUKHLfNdpmgwMc06nDKe3ZzSgY4JWETYCzlE5SWD4PZYmw==", null, false, "7ae3b37a-5952-4f30-9b21-cf4b57f1405f", false, "Mattie.Nienow" },
                    { "cef72b71-6ebe-4df4-9f36-6c660c56f76f", 0, "90af953d-d42c-4140-ba54-bd835248326e", "Rita_Homenick64@yahoo.com", false, true, null, "RITA_HOMENICK64@YAHOO.COM", "RITA60", "AQAAAAIAAYagAAAAEIbAAkvazi7aUYTjYsJnGEXnyxCZDYKkMY7t2E07vJMBH0H9zt/lvvA5tpNMWBCh5A==", null, false, "3982698c-7a62-41fe-9988-52e640b1090a", false, "Rita60" },
                    { "cfb8babc-7ab7-4b70-8978-d1c3ae31a8fb", 0, "1800cc92-20c9-4b54-9308-71e55f50f0ab", "Maurice.Raynor28@gmail.com", false, true, null, "MAURICE.RAYNOR28@GMAIL.COM", "MAURICE_RAYNOR49", "AQAAAAIAAYagAAAAEOrTaWhqmW/yMgbvEm/pejqZgyOAEwkEJuDco0hQ5TI22u338Ogi9xDQvFcx680PyQ==", null, false, "73957d53-4a65-4213-91be-354589e3779a", false, "Maurice_Raynor49" },
                    { "d018f696-13c6-4b75-b366-213aacee64f3", 0, "8536bbbe-8359-4ea7-a584-edeba3a93bb6", "Joyce12@gmail.com", false, true, null, "JOYCE12@GMAIL.COM", "JOYCE_TROMP2", "AQAAAAIAAYagAAAAELQYtM81Yw3OHsecMRxYqocERVB333qjmgkjBqfo+twwNg+bZE9vN5K5quVUj9de/Q==", null, false, "9b1377e5-3353-4ac3-b466-fe6d590a166f", false, "Joyce_Tromp2" },
                    { "d38aabc7-655f-4dd6-927f-b72aa443a573", 0, "9d919d85-faa7-42d5-b619-c82d6f87029e", "Kathy65@gmail.com", false, true, null, "KATHY65@GMAIL.COM", "KATHY72", "AQAAAAIAAYagAAAAEFD72V9BdjYEhFh0bZwpGBUYrRFFjRlg5MEeAqfeyY2oipytNKceGrzJ7iHF1KfMSQ==", null, false, "ca229e1b-711f-47cd-a860-88728b102d26", false, "Kathy72" },
                    { "d75cc08c-4a64-49af-ae79-0ec7d33f2f79", 0, "e56d6b8e-9815-4f8d-84bb-be810c69a5b1", "Loretta.Kulas1@hotmail.com", false, true, null, "LORETTA.KULAS1@HOTMAIL.COM", "LORETTA.KULAS", "AQAAAAIAAYagAAAAEMjqiWHK9SeoBl2kUIYHKWgzMiwJmgVbqAbXLtekE79mQvmdUU6QCTRmqgBDXTFV5Q==", null, false, "0ab207a3-54d6-46f5-89fe-cdb35e01954d", false, "Loretta.Kulas" },
                    { "da74d4bc-fdd2-431a-b71e-521b1fae15dd", 0, "10e948c4-9c5f-45f3-9f8c-7ce63420a86f", "Theodore8@gmail.com", false, true, null, "THEODORE8@GMAIL.COM", "THEODORE.COLLIER", "AQAAAAIAAYagAAAAEFvTdg5fozGFheFU511Nw0Aw5pXAoPHks/DM80zQU7NjDWbtMzV8DhahjW4e346Iiw==", null, false, "800cc5c9-3ff1-4a62-a817-f052f21b23e6", false, "Theodore.Collier" },
                    { "dc27a7de-1c72-4032-9ad0-3d2a0152b4a5", 0, "2be3c964-d49d-4537-a81b-0f747d88287d", "Irving_Satterfield@hotmail.com", false, true, null, "IRVING_SATTERFIELD@HOTMAIL.COM", "IRVING_SATTERFIELD27", "AQAAAAIAAYagAAAAEADzrvvMzZAnIPbngy01VFuHycRgy5B+oOc6USuSVbIpYzh7Q9e6Xc9cuTJcv9YCJw==", null, false, "37edfea3-7c7e-4a82-839d-22f7313d2a68", false, "Irving_Satterfield27" },
                    { "dd628fd2-171f-4a16-bd2f-1740a2fd2f3a", 0, "09cb3136-2b02-4378-91c4-a41fbb1796f8", "Roosevelt_Smith67@gmail.com", false, true, null, "ROOSEVELT_SMITH67@GMAIL.COM", "ROOSEVELT_SMITH", "AQAAAAIAAYagAAAAEKk4jIGhaMjHAIJnP5itjwUPIZ9iOsOrtUiDXmmAinESIxaZTnHoFzDhogTALorhZw==", null, false, "6c868034-4676-438e-ab36-39038891eb1c", false, "Roosevelt_Smith" },
                    { "e109c746-2908-46ef-abf4-7575b1896ab7", 0, "49ca2a32-4e19-4277-aa53-0d4af4c8e564", "Van.Christiansen@gmail.com", false, true, null, "VAN.CHRISTIANSEN@GMAIL.COM", "VAN.CHRISTIANSEN32", "AQAAAAIAAYagAAAAECk3ySAwhVXS1+M1Y1oK153Z6S8NM2idNeuUIr4G5i5fc8oAJfahIcCG8PCFKUT26g==", null, false, "48aec45a-8cb8-4a8c-85a1-c378ed8d9ce1", false, "Van.Christiansen32" },
                    { "e2a10301-5508-4d33-8d25-e2c9bf6462db", 0, "e6905dea-599e-486c-ad2a-ed6452548eaf", "Billie.Ernser26@yahoo.com", false, true, null, "BILLIE.ERNSER26@YAHOO.COM", "BILLIE.ERNSER33", "AQAAAAIAAYagAAAAECNiSyRuFUaNEu4KuBAXAwSpvUsCFmeSBS8h7KAq0rcgbWvoeV5k9+VmSoT08EkCjg==", null, false, "91a68532-91db-4fee-b0cc-58d68f742cde", false, "Billie.Ernser33" },
                    { "e4541fcd-895a-488c-93ec-4aee1c8036d1", 0, "6fdbd1a9-3f49-49de-8065-7ba99a8e9551", "Claude72@gmail.com", false, true, null, "CLAUDE72@GMAIL.COM", "CLAUDE_BOYER", "AQAAAAIAAYagAAAAELAFo9HOPqwMgYQgHmTCQrQoBhE2f/ypg05jzp845XDKrZMa19d9dGxMm3PGTaABHg==", null, false, "a733d90f-44d6-4f4c-bc5a-179a8d6aa0d4", false, "Claude_Boyer" },
                    { "e59fd29d-d79b-4b46-9089-d63294f3e721", 0, "058ccafc-0e22-4385-bfbb-65fd4bbf93e4", "Becky_Bode@yahoo.com", false, true, null, "BECKY_BODE@YAHOO.COM", "BECKY_BODE4", "AQAAAAIAAYagAAAAEHanH6O6XQUU3pi8vQ24EVEmfVinZjArF/t3qTZSozjsdoDvXCIcX1XrVWBv+4Uf6g==", null, false, "55c14dae-7372-4add-a0e0-6d8de04aa641", false, "Becky_Bode4" },
                    { "e5c802f9-ddcb-4d7f-b6ea-651eb0ba0809", 0, "2f1bba69-92c2-4494-9f2e-d19201a34024", "Jody.Koch72@hotmail.com", false, true, null, "JODY.KOCH72@HOTMAIL.COM", "JODY.KOCH", "AQAAAAIAAYagAAAAELxwvXLmbhK/ZJSiICETtzN01Jj9LM3euwWUWQv0vNtspsEwsmDAjUIhCYl3DIMQMA==", null, false, "9baea0a3-7cbe-4435-abfb-1ce118041311", false, "Jody.Koch" },
                    { "e6ff9fe1-c98b-4975-93fe-4ad1d6ad3e7c", 0, "3d0dcade-2d25-4cec-ad10-45ab46500a09", "Anna_Cartwright83@hotmail.com", false, true, null, "ANNA_CARTWRIGHT83@HOTMAIL.COM", "ANNA.CARTWRIGHT", "AQAAAAIAAYagAAAAEI8e4K0O6PNyRCyrucE+7Ay1drNDazhLVZNsr7r+wc4gVp9rjBIN9394woRKLEJMMA==", null, false, "13c03416-a9df-4b5c-9887-b8799c7090ef", false, "Anna.Cartwright" },
                    { "ee298a33-0dea-4b3a-8d5d-0aeb6824bf05", 0, "031d62e8-98e2-4c1e-bb9d-e3c8cbb40de2", "Joel.Schulist@yahoo.com", false, true, null, "JOEL.SCHULIST@YAHOO.COM", "JOEL.SCHULIST84", "AQAAAAIAAYagAAAAEKX0VCg8J9aOYERADGCCiVbvYvSep7a7lxGMt32nfgfQ60xzKzag3TRWCUo9BqG0ow==", null, false, "459b9ea7-7c46-4bbb-b5a9-8b629c9d947a", false, "Joel.Schulist84" },
                    { "ef6be18e-b92a-4823-be1e-6b737aa468fd", 0, "0d63c3b9-6e87-44f3-ad7a-5351370b6b62", "Lucia.McDermott47@yahoo.com", false, true, null, "LUCIA.MCDERMOTT47@YAHOO.COM", "LUCIA_MCDERMOTT67", "AQAAAAIAAYagAAAAEF3CHkJUjvOPuCNeo46KhqbjvB0hC7h7/VLyBvVExwhhFUhA5YGgZfxb2my41mfZRA==", null, false, "aae5f0d1-9be5-4b1c-a4b0-3a7f7be8079d", false, "Lucia_McDermott67" },
                    { "f7214394-68e1-4c8e-a726-565b3242f2b8", 0, "d4a4cb4c-0290-4484-8084-4e7bf006836c", "Sue37@gmail.com", false, true, null, "SUE37@GMAIL.COM", "SUE_FRIESEN25", "AQAAAAIAAYagAAAAEPRz/O4jUKLpDuYkirlEI7Fl//YLz7pTVDbwc98wr+XjkjU+32RsR7QBn0m/t9b3cQ==", null, false, "61584ba9-baad-4c8e-b892-3540a8a4bbbd", false, "Sue_Friesen25" },
                    { "fcd4eeac-85a0-4ca4-b7f6-f144bee944bd", 0, "ccd24346-ee22-459a-92cd-2ca7483192c5", "Michael.Muller@yahoo.com", false, true, null, "MICHAEL.MULLER@YAHOO.COM", "MICHAEL_MULLER", "AQAAAAIAAYagAAAAEGZj7eMe6XmfwauGQyd/4FzKo03mqeRYFVsVW6hWu32XE+RcH1DRP32KB/dEs0g/qQ==", null, false, "7cfb5597-7b71-4854-bb34-a55e0064e147", false, "Michael_Muller" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "01766675-a912-4f43-92f0-83fb64d9360a" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "03b9bf21-5b8a-4c82-ab97-97f6d65356e9" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0459ef7c-8069-461a-9893-7df5f3fc8e3d" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "049e9eb8-b612-4140-8e4b-9382074b0a6f" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "04a70a68-9bae-4eca-9122-caac546f62a4" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "06827f98-7153-4f4f-995c-f4fefaf59bb6" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "08056d72-0447-40e6-ae8e-dc19679c626c" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0a6992b4-3d98-471d-94b7-2a6e9a1d1889" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0cdb00ee-31ca-421a-b9a9-accf487be449" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0d0bf0ce-044f-4464-b1c3-38568f1fb9ef" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "118ea5a2-f110-427c-8a93-1c742e84e781" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "12897c7e-4203-4160-b7bd-5eb2bd7dcffb" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "168369ef-3476-4ebc-b86c-e509ac147514" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "16ce8387-0c6a-4074-ac75-748ac19b6e65" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "1dd0799d-c242-494e-b46a-0e0d8ee56860" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "1dd156ee-acb8-40d4-aa20-e46004c1e1de" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "242bf0aa-a17f-4f07-9b1b-725c2398f2a1" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2843d530-0182-43ac-a0d9-5ed1dd6751c4" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2a531804-0713-4881-b672-b823979245ca" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2b22e75a-76f7-4137-ac9a-52e7068b08c1" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2d84dd81-4ba7-4cc0-8521-bd2df30ed9ca" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2f0edde9-d030-4625-9c28-f45b3d3731ce" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2f479edb-55e8-44a2-8da2-5112255a99de" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "366616d3-60b9-4eb9-9645-b7a3f25897ee" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "39669ccb-7ea1-406a-93aa-e1d1347f832e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3b0a65c2-11dc-4ee4-9e1b-66808f9b06ce" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3b318fb2-4ef7-43aa-9d19-4730046e9c6d" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3ec7c3b0-ff85-4dae-9428-e9629d60b62e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3feb375c-09ee-4c01-a906-591a37957729" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "439a1d11-b992-4489-9eb5-2937ea05a9a5" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "43b40e27-555f-46cc-bcfb-9599eb0e637b" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "44b4b0ad-fceb-4829-b618-c000ac9730b3" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "477bdbd0-2eb8-4440-ab2b-8c8bbef1a4a6" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4793d21c-ffc3-4dc8-9318-43370340bad7" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4b991469-5cea-4dee-8ace-98a4e19f1085" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4e027cc9-1c7f-4191-b8c9-e65efdb9fbad" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "4f8e9bdf-1f6f-4e97-a308-fc4d5e29fdae" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "57462865-b8a8-462a-b13b-25ba231066b6" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "583221dc-b51a-4c78-bcc8-26d776fcbd35" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5bc0afa6-2239-4e16-81ec-50ce4cbc3f2e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5d84d6a7-bb5a-414c-86e8-4bed157f452e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5f90f56d-7aa5-4cc0-9c55-ab1f610e917a" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "60b4e72a-66bb-4a91-9cef-f871375e6281" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "62a3d59d-2050-4cae-beb0-9cb3a9db6609" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "62ed6a0d-1d38-4fdd-9b4d-0742d8d74e6f" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "64d26882-a877-482a-a991-7cfb39b2f778" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "6bad754d-5278-4ff4-9edc-eec5582ae45b" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "727a24a3-edfb-4d30-a235-4333ce4218e3" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "735a8878-d946-4cea-8b66-9689378adc35" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "749e6c3e-79e4-40fc-bc65-2cc32970bb12" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "75d801f0-4c1a-4ec4-a7a0-59b1f979f66a" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7638d278-0874-4d7c-a9eb-648c8000453c" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7667b7af-e2d3-486d-a1f7-6ed9638d4153" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7b4d1a63-1683-4b90-8104-071ea7abb606" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "89303085-7a2b-49c0-835d-eef31ce61354" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "895d46f5-3059-4064-b091-46466450cd38" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8b4580e9-c4cc-44ea-9210-65dda58b07a8" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8bfca591-2828-4e77-81d2-7e6d4fe2e29e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8ec7b2b1-a845-40ec-a0ac-2ff4065793ea" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "99afc2f9-00e7-4ec4-b06b-f6993f7c7051" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "9c09edea-c9fa-4260-9517-1f793ab2ca2a" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "9ca8885c-c056-44d7-beda-eb8297d86d10" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a00b9d22-e2f7-402b-974f-dd2e927df0df" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a0b1b6dd-fb6e-49bf-a382-e649549103c8" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "a1769368-0488-4930-8cd8-98d0d24b7f89" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "a463542a-e2db-493b-bed0-85e93b7f830b" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a4e42453-e20c-44a8-8a7e-06802eb5d15e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a54c935c-d6b5-4f19-adfe-b0e335b60ac7" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a54f09d3-570e-4afc-af52-1069253e7734" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a7a8e9c6-773a-48b6-a3dc-34fa0090e0c3" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a842a0c1-eb9b-41ff-87d8-aa267d08ecdd" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a925cd0a-0212-430e-a099-0f3d82334494" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "acdb748b-10b5-45d6-adfd-3a4a90905584" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "aef9dc5d-df7a-40b7-94ba-c1e7c3b3ff0e" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "b0c2d9b3-24da-4830-b49e-64006ab57805" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "b9f6657c-d133-44b3-ac8e-1667572cd437" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "bbc85c75-fe0f-4cac-91dc-133ecc2c32d4" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "c0c439ed-1002-455e-8ccd-06ad397c8972" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "c31ebb00-2da6-4117-b001-b5eaa58c906d" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ca51e6af-dde5-4d7a-98b1-258a4cc4bb57" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cb562c30-ec91-4451-902b-94b96f1b05e3" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cd7ba642-40ff-4341-ba00-98734ac4d359" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cef72b71-6ebe-4df4-9f36-6c660c56f76f" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cfb8babc-7ab7-4b70-8978-d1c3ae31a8fb" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "d018f696-13c6-4b75-b366-213aacee64f3" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "d38aabc7-655f-4dd6-927f-b72aa443a573" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "d75cc08c-4a64-49af-ae79-0ec7d33f2f79" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "da74d4bc-fdd2-431a-b71e-521b1fae15dd" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "dc27a7de-1c72-4032-9ad0-3d2a0152b4a5" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "dd628fd2-171f-4a16-bd2f-1740a2fd2f3a" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e109c746-2908-46ef-abf4-7575b1896ab7" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e2a10301-5508-4d33-8d25-e2c9bf6462db" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e4541fcd-895a-488c-93ec-4aee1c8036d1" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e59fd29d-d79b-4b46-9089-d63294f3e721" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e5c802f9-ddcb-4d7f-b6ea-651eb0ba0809" },
                    { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "e6ff9fe1-c98b-4975-93fe-4ad1d6ad3e7c" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ee298a33-0dea-4b3a-8d5d-0aeb6824bf05" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ef6be18e-b92a-4823-be1e-6b737aa468fd" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "f7214394-68e1-4c8e-a726-565b3242f2b8" },
                    { "9a13f51b-457c-4d91-9164-ef3fce898c99", "fcd4eeac-85a0-4ca4-b7f6-f144bee944bd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "01766675-a912-4f43-92f0-83fb64d9360a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "03b9bf21-5b8a-4c82-ab97-97f6d65356e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0459ef7c-8069-461a-9893-7df5f3fc8e3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "049e9eb8-b612-4140-8e4b-9382074b0a6f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "04a70a68-9bae-4eca-9122-caac546f62a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "06827f98-7153-4f4f-995c-f4fefaf59bb6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "08056d72-0447-40e6-ae8e-dc19679c626c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0a6992b4-3d98-471d-94b7-2a6e9a1d1889" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0cdb00ee-31ca-421a-b9a9-accf487be449" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "0d0bf0ce-044f-4464-b1c3-38568f1fb9ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "118ea5a2-f110-427c-8a93-1c742e84e781" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "12897c7e-4203-4160-b7bd-5eb2bd7dcffb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "168369ef-3476-4ebc-b86c-e509ac147514" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "16ce8387-0c6a-4074-ac75-748ac19b6e65" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "1dd0799d-c242-494e-b46a-0e0d8ee56860" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "1dd156ee-acb8-40d4-aa20-e46004c1e1de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "242bf0aa-a17f-4f07-9b1b-725c2398f2a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2843d530-0182-43ac-a0d9-5ed1dd6751c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2a531804-0713-4881-b672-b823979245ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2b22e75a-76f7-4137-ac9a-52e7068b08c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2d84dd81-4ba7-4cc0-8521-bd2df30ed9ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2f0edde9-d030-4625-9c28-f45b3d3731ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "2f479edb-55e8-44a2-8da2-5112255a99de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "366616d3-60b9-4eb9-9645-b7a3f25897ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "39669ccb-7ea1-406a-93aa-e1d1347f832e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3b0a65c2-11dc-4ee4-9e1b-66808f9b06ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3b318fb2-4ef7-43aa-9d19-4730046e9c6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3ec7c3b0-ff85-4dae-9428-e9629d60b62e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "3feb375c-09ee-4c01-a906-591a37957729" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "439a1d11-b992-4489-9eb5-2937ea05a9a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "43b40e27-555f-46cc-bcfb-9599eb0e637b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "44b4b0ad-fceb-4829-b618-c000ac9730b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "477bdbd0-2eb8-4440-ab2b-8c8bbef1a4a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4793d21c-ffc3-4dc8-9318-43370340bad7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4b991469-5cea-4dee-8ace-98a4e19f1085" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "4e027cc9-1c7f-4191-b8c9-e65efdb9fbad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "4f8e9bdf-1f6f-4e97-a308-fc4d5e29fdae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "57462865-b8a8-462a-b13b-25ba231066b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "583221dc-b51a-4c78-bcc8-26d776fcbd35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5bc0afa6-2239-4e16-81ec-50ce4cbc3f2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5d84d6a7-bb5a-414c-86e8-4bed157f452e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "5f90f56d-7aa5-4cc0-9c55-ab1f610e917a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "60b4e72a-66bb-4a91-9cef-f871375e6281" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "62a3d59d-2050-4cae-beb0-9cb3a9db6609" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "62ed6a0d-1d38-4fdd-9b4d-0742d8d74e6f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "64d26882-a877-482a-a991-7cfb39b2f778" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "6bad754d-5278-4ff4-9edc-eec5582ae45b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "727a24a3-edfb-4d30-a235-4333ce4218e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "735a8878-d946-4cea-8b66-9689378adc35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "749e6c3e-79e4-40fc-bc65-2cc32970bb12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "75d801f0-4c1a-4ec4-a7a0-59b1f979f66a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7638d278-0874-4d7c-a9eb-648c8000453c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7667b7af-e2d3-486d-a1f7-6ed9638d4153" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "7b4d1a63-1683-4b90-8104-071ea7abb606" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "89303085-7a2b-49c0-835d-eef31ce61354" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "895d46f5-3059-4064-b091-46466450cd38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8b4580e9-c4cc-44ea-9210-65dda58b07a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8bfca591-2828-4e77-81d2-7e6d4fe2e29e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "8ec7b2b1-a845-40ec-a0ac-2ff4065793ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "99afc2f9-00e7-4ec4-b06b-f6993f7c7051" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "9c09edea-c9fa-4260-9517-1f793ab2ca2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "9ca8885c-c056-44d7-beda-eb8297d86d10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a00b9d22-e2f7-402b-974f-dd2e927df0df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a0b1b6dd-fb6e-49bf-a382-e649549103c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "a1769368-0488-4930-8cd8-98d0d24b7f89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "a463542a-e2db-493b-bed0-85e93b7f830b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a4e42453-e20c-44a8-8a7e-06802eb5d15e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a54c935c-d6b5-4f19-adfe-b0e335b60ac7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a54f09d3-570e-4afc-af52-1069253e7734" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a7a8e9c6-773a-48b6-a3dc-34fa0090e0c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a842a0c1-eb9b-41ff-87d8-aa267d08ecdd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "a925cd0a-0212-430e-a099-0f3d82334494" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "acdb748b-10b5-45d6-adfd-3a4a90905584" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "aef9dc5d-df7a-40b7-94ba-c1e7c3b3ff0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "b0c2d9b3-24da-4830-b49e-64006ab57805" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "b9f6657c-d133-44b3-ac8e-1667572cd437" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "bbc85c75-fe0f-4cac-91dc-133ecc2c32d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "c0c439ed-1002-455e-8ccd-06ad397c8972" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "c31ebb00-2da6-4117-b001-b5eaa58c906d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ca51e6af-dde5-4d7a-98b1-258a4cc4bb57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cb562c30-ec91-4451-902b-94b96f1b05e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cd7ba642-40ff-4341-ba00-98734ac4d359" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cef72b71-6ebe-4df4-9f36-6c660c56f76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "cfb8babc-7ab7-4b70-8978-d1c3ae31a8fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "d018f696-13c6-4b75-b366-213aacee64f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "d38aabc7-655f-4dd6-927f-b72aa443a573" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "d75cc08c-4a64-49af-ae79-0ec7d33f2f79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "da74d4bc-fdd2-431a-b71e-521b1fae15dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "dc27a7de-1c72-4032-9ad0-3d2a0152b4a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "dd628fd2-171f-4a16-bd2f-1740a2fd2f3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e109c746-2908-46ef-abf4-7575b1896ab7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e2a10301-5508-4d33-8d25-e2c9bf6462db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e4541fcd-895a-488c-93ec-4aee1c8036d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e59fd29d-d79b-4b46-9089-d63294f3e721" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "e5c802f9-ddcb-4d7f-b6ea-651eb0ba0809" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30", "e6ff9fe1-c98b-4975-93fe-4ad1d6ad3e7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ee298a33-0dea-4b3a-8d5d-0aeb6824bf05" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "ef6be18e-b92a-4823-be1e-6b737aa468fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "f7214394-68e1-4c8e-a726-565b3242f2b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a13f51b-457c-4d91-9164-ef3fce898c99", "fcd4eeac-85a0-4ca4-b7f6-f144bee944bd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a13f51b-457c-4d91-9164-ef3fce898c99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ff8ff1-b0ec-4f66-b179-1a5e54c2ab30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01766675-a912-4f43-92f0-83fb64d9360a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03b9bf21-5b8a-4c82-ab97-97f6d65356e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0459ef7c-8069-461a-9893-7df5f3fc8e3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "049e9eb8-b612-4140-8e4b-9382074b0a6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a70a68-9bae-4eca-9122-caac546f62a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06827f98-7153-4f4f-995c-f4fefaf59bb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08056d72-0447-40e6-ae8e-dc19679c626c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a6992b4-3d98-471d-94b7-2a6e9a1d1889");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cdb00ee-31ca-421a-b9a9-accf487be449");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d0bf0ce-044f-4464-b1c3-38568f1fb9ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ea5a2-f110-427c-8a93-1c742e84e781");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12897c7e-4203-4160-b7bd-5eb2bd7dcffb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168369ef-3476-4ebc-b86c-e509ac147514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16ce8387-0c6a-4074-ac75-748ac19b6e65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dd0799d-c242-494e-b46a-0e0d8ee56860");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dd156ee-acb8-40d4-aa20-e46004c1e1de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "242bf0aa-a17f-4f07-9b1b-725c2398f2a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2843d530-0182-43ac-a0d9-5ed1dd6751c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a531804-0713-4881-b672-b823979245ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b22e75a-76f7-4137-ac9a-52e7068b08c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d84dd81-4ba7-4cc0-8521-bd2df30ed9ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f0edde9-d030-4625-9c28-f45b3d3731ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f479edb-55e8-44a2-8da2-5112255a99de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "366616d3-60b9-4eb9-9645-b7a3f25897ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39669ccb-7ea1-406a-93aa-e1d1347f832e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b0a65c2-11dc-4ee4-9e1b-66808f9b06ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b318fb2-4ef7-43aa-9d19-4730046e9c6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ec7c3b0-ff85-4dae-9428-e9629d60b62e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3feb375c-09ee-4c01-a906-591a37957729");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "439a1d11-b992-4489-9eb5-2937ea05a9a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b40e27-555f-46cc-bcfb-9599eb0e637b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44b4b0ad-fceb-4829-b618-c000ac9730b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "477bdbd0-2eb8-4440-ab2b-8c8bbef1a4a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4793d21c-ffc3-4dc8-9318-43370340bad7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b991469-5cea-4dee-8ace-98a4e19f1085");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e027cc9-1c7f-4191-b8c9-e65efdb9fbad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f8e9bdf-1f6f-4e97-a308-fc4d5e29fdae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57462865-b8a8-462a-b13b-25ba231066b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "583221dc-b51a-4c78-bcc8-26d776fcbd35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bc0afa6-2239-4e16-81ec-50ce4cbc3f2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d84d6a7-bb5a-414c-86e8-4bed157f452e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f90f56d-7aa5-4cc0-9c55-ab1f610e917a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60b4e72a-66bb-4a91-9cef-f871375e6281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62a3d59d-2050-4cae-beb0-9cb3a9db6609");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62ed6a0d-1d38-4fdd-9b4d-0742d8d74e6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64d26882-a877-482a-a991-7cfb39b2f778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bad754d-5278-4ff4-9edc-eec5582ae45b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "727a24a3-edfb-4d30-a235-4333ce4218e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "735a8878-d946-4cea-8b66-9689378adc35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "749e6c3e-79e4-40fc-bc65-2cc32970bb12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75d801f0-4c1a-4ec4-a7a0-59b1f979f66a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7638d278-0874-4d7c-a9eb-648c8000453c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7667b7af-e2d3-486d-a1f7-6ed9638d4153");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b4d1a63-1683-4b90-8104-071ea7abb606");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89303085-7a2b-49c0-835d-eef31ce61354");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "895d46f5-3059-4064-b091-46466450cd38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b4580e9-c4cc-44ea-9210-65dda58b07a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bfca591-2828-4e77-81d2-7e6d4fe2e29e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ec7b2b1-a845-40ec-a0ac-2ff4065793ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99afc2f9-00e7-4ec4-b06b-f6993f7c7051");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c09edea-c9fa-4260-9517-1f793ab2ca2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ca8885c-c056-44d7-beda-eb8297d86d10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a00b9d22-e2f7-402b-974f-dd2e927df0df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0b1b6dd-fb6e-49bf-a382-e649549103c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1769368-0488-4930-8cd8-98d0d24b7f89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a463542a-e2db-493b-bed0-85e93b7f830b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4e42453-e20c-44a8-8a7e-06802eb5d15e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a54c935c-d6b5-4f19-adfe-b0e335b60ac7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a54f09d3-570e-4afc-af52-1069253e7734");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7a8e9c6-773a-48b6-a3dc-34fa0090e0c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a842a0c1-eb9b-41ff-87d8-aa267d08ecdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a925cd0a-0212-430e-a099-0f3d82334494");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acdb748b-10b5-45d6-adfd-3a4a90905584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aef9dc5d-df7a-40b7-94ba-c1e7c3b3ff0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0c2d9b3-24da-4830-b49e-64006ab57805");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9f6657c-d133-44b3-ac8e-1667572cd437");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbc85c75-fe0f-4cac-91dc-133ecc2c32d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0c439ed-1002-455e-8ccd-06ad397c8972");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c31ebb00-2da6-4117-b001-b5eaa58c906d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca51e6af-dde5-4d7a-98b1-258a4cc4bb57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb562c30-ec91-4451-902b-94b96f1b05e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd7ba642-40ff-4341-ba00-98734ac4d359");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cef72b71-6ebe-4df4-9f36-6c660c56f76f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfb8babc-7ab7-4b70-8978-d1c3ae31a8fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d018f696-13c6-4b75-b366-213aacee64f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d38aabc7-655f-4dd6-927f-b72aa443a573");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75cc08c-4a64-49af-ae79-0ec7d33f2f79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da74d4bc-fdd2-431a-b71e-521b1fae15dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc27a7de-1c72-4032-9ad0-3d2a0152b4a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd628fd2-171f-4a16-bd2f-1740a2fd2f3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e109c746-2908-46ef-abf4-7575b1896ab7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a10301-5508-4d33-8d25-e2c9bf6462db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4541fcd-895a-488c-93ec-4aee1c8036d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e59fd29d-d79b-4b46-9089-d63294f3e721");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5c802f9-ddcb-4d7f-b6ea-651eb0ba0809");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6ff9fe1-c98b-4975-93fe-4ad1d6ad3e7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee298a33-0dea-4b3a-8d5d-0aeb6824bf05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef6be18e-b92a-4823-be1e-6b737aa468fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7214394-68e1-4c8e-a726-565b3242f2b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcd4eeac-85a0-4ca4-b7f6-f144bee944bd");
        }
    }
}
