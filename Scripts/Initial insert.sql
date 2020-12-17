USE [wBees]
GO
  insert into [AspNetRoles]
  (Id, Name, NormalizedName)
  values
  (NEWID(), 'Admin', 'ADMIN'),  
  (NEWID(), 'Bee', 'BEE'),  
  (NEWID(), 'Flower', 'FLOWER'),  
  (NEWID(), 'Guest', 'Guest')

INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'c2eefa85-5cdc-4cbb-9d96-05c8222bf487', N'new')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'dc6efba8-7b43-4095-84bf-0a823e823253', N'new')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc', N'Education')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'9e023960-3cbf-493c-a21e-171252455a84', N'Media')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'638a25da-3633-441e-9c65-208e6b0a8a17', N'Business')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'9ed88fca-beec-4bb4-abf2-3282fa5b0011', N'Technology')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'b92b8029-e626-4d99-beb4-60ba92183efb', N'Arts')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'c076f17e-8e4a-4ef0-89f0-7da5e2256849', N'Medical')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e', N'Service Industry')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'65d85040-4ec4-4ea9-9658-b0f4090a1a3f', N'First')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'40918366-20a7-4856-9b00-c3a1ec86083a', N'Law Enforcement')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'5db290a3-4d96-43ed-bf6d-f04ca40e96a6', N'Other Options')
INSERT [dbo].[Industries] ([Id], [Name]) VALUES (N'60b73baa-1375-46f1-8c7e-f0de498e4c51', N'Aviation')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'77c1a9d6-6f46-4832-a5c7-04f0634afec1', N'Fundraiser', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'267b719d-b577-47ab-abf2-05fb107e6604', N'Retail', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'd19cbbde-aff6-42d4-a589-0653d46ddbc0', N'Back End Developer', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'2a6025f2-4ba5-486d-9560-06cfb555ec39', N'Physician Assistant', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'56848b59-33f1-4d9c-b064-091f10280348', N'Freelance Writer', N'9e023960-3cbf-493c-a21e-171252455a84')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'de83ab59-79ca-455b-b810-09cd5b001f44', N'Orthodontist', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'c3cdd668-855d-4145-8b26-0a9c2f13714f', N'Programmer', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'017e432b-f43c-4884-9051-0bdafd868b67', N'Database Administrator', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'77888702-c524-41e6-b61e-1598179184f3', N'School Jobs', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'04f53e3d-212f-4894-a840-179cff6df7a6', N'College Professor', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'cb4f018b-2bda-4869-9df3-2075dc5a9772', N'Lawyer', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'72d60154-0bbe-49bd-b0ae-231a0841c06e', N'Flight Attendant', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'0c1400ed-91a8-47a9-b563-28966eccfc20', N'Doctor', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e2f41b66-352f-43e5-8df8-2b775900b83f', N'Psychiatrist', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'ee34ab3f-2464-4f49-a1e3-2dad7558cc91', N'Personal Fitness Trainer', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'3da525c5-cd32-47c0-bc1e-32531c243796', N'Police Officer', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'b701cdf3-4541-436d-9ba0-33b1deebfac2', N'Military Careers', N'5db290a3-4d96-43ed-bf6d-f04ca40e96a6')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'b4a318a3-d8de-45a3-a48e-33f46e6fd7ac', N'Writer/Editor', N'9e023960-3cbf-493c-a21e-171252455a84')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'7f3aef40-8059-4852-b78e-359ed7d135cf', N'Public Relations', N'9e023960-3cbf-493c-a21e-171252455a84')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'f9fc0ae1-aea9-4517-9bfb-3667f2b58366', N'Administrative Assistant/Secretary', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'baf95c4a-172f-44a1-a471-3ea96546da9f', N'Insurance Agent', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'cce31582-8cef-4be0-a18e-42448f8251bd', N'Accountant', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'b72c23d1-797f-4853-9a3d-46b9cd845a88', N'Architect', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e3a3db80-6fb1-4674-8df9-4f9a83e1a192', N'Aircraft Dispatcher', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'ff68ad9d-53ca-4d13-8ca8-4fc5c3dc3b70', N'Music Conductor', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'7a686ed2-76fa-47b5-a814-5074c885f2f6', N'Advertising', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e53dd6ca-079d-4830-86d0-5488d4bf4645', N'Wedding Planner', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'5b45c78e-8ba2-402b-8ab6-5c4840cd8819', N'Human Resources', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'6fb66c42-aa28-42c3-8584-5d56763ab32a', N'Actor', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'5c2423ae-a36b-4cfc-81a9-6203dce1bb19', N'Pediatrician', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'015ee8dc-b456-4217-a204-635244bc0db1', N'Paramedic', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'd6a6e602-0cfa-421d-abcb-679878e39644', N'Hair Stylist', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'3d3b0188-ca57-45ff-a808-68ac008e17d8', N'Artist', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'71789af4-8bcd-45ae-bcc8-6ce66397dccd', N'Social Worker', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'078275e2-3d90-48fd-9e08-6f105ea54c12', N'City Manager', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'43206e59-2d10-454a-9ec5-6f16063d42fe', N'Teaching Abroad', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'9b291bdd-c269-483d-9ca1-70f00da400de', N'Consultant', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e0a7df76-5ebd-4592-9e66-73458617fce4', N'Bank Teller', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'f8753b22-d3fe-43ae-bf53-74e387278740', N'Chief Operating Officer', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'a0e674da-f991-4c79-8e2d-78bb98bf88a3', N'Computer Programmer', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'a4dd12a2-e86c-4011-9d70-80d7656d154f', N'Financial Advisor', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'7aef82df-6d64-4053-b8f5-87375c23d6ac', N'Art Appraiser', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'911b578a-5651-4707-a2f2-8fa38bf2a59d', N'Federal Air Marshall', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'c42a46d0-9bbb-4949-9457-939c02878a53', N'Uniformed Secret Service Officer', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'073644e4-7ea0-4c0f-a33f-9702ffdbb7e8', N'Management', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'45fb851a-1cf5-43b3-8930-97e463d089a9', N'Police Dispatcher', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'a0424c0c-124a-4585-b76c-98202ad42b47', N'Government Jobs', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'abbe46f6-63f2-48ab-87e8-9e32b5a822af', N'Sales', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'0f2f7ac8-6729-4ae5-aa2f-9e822591d3d9', N'Transportation Security Officer', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'a32da2ee-787c-42c8-91ad-a1fbd906ba0d', N'Book Publishing', N'9e023960-3cbf-493c-a21e-171252455a84')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'05134613-f288-4cb8-9dfc-a2f56610cb72', N'Animal Careers', N'5db290a3-4d96-43ed-bf6d-f04ca40e96a6')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e631c468-2ad6-49da-945a-ace475064bd6', N'Art Auctioneer', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e5fb9020-8b34-4711-a2db-ae409142e920', N'Psychologist', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'5ff2285b-cf4d-4091-a5c9-b02e54145423', N'Border Control Agent', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'421cde5b-3995-4457-898d-b45362f84b6c', N'Airline Pilot', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'09bc1c5a-263b-4826-a351-c251c1055cb5', N'Web Developer', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e7a21025-adc7-4d75-89d0-c3292a80c428', N'Web Developer', N'9e023960-3cbf-493c-a21e-171252455a84')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'6167ad3d-d92f-4464-a671-c4316d119acf', N'Market Research Analyst', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'b2ecf792-1640-47b2-8ac1-caa3cd163baa', N'Music Teacher', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'08989ea4-9a09-44ca-99ac-ce7b4a8d3afb', N'Investment Banker', N'638a25da-3633-441e-9c65-208e6b0a8a17')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'4f7e9010-5c6e-4bba-90ca-ce916766c0c0', N'Correctional Officer', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'879d8213-888d-4f98-9ea9-d0011f2cfa71', N'Museum Jobs', N'b92b8029-e626-4d99-beb4-60ba92183efb')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e7ec6b79-308b-4f7a-ad38-d26d082cb43f', N'Computer Systems Administrator', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'a8981d2a-e84c-40cb-b12b-dca8f40911fe', N'Call Center', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'5641ce76-3af0-4f68-80b4-dd427456bcbd', N'Waiter', N'3d8d6c09-d087-4195-bdb1-8d0f9a2d212e')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'c75d6388-2eed-4c76-8f48-e0a469c6127e', N'Nurse', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'8715450b-d743-4cda-9d3e-e22a1aae81bf', N'Criminal Justice', N'40918366-20a7-4856-9b00-c3a1ec86083a')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'8f1f9e71-e549-4aee-ad8b-e575737c78d7', N'Mental Health Counselor', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'7a11bbae-614e-4362-b34e-e75062bcfe9f', N'Teaching Online', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'5d7982f2-e167-4975-81cd-ed281813f8c3', N'Substitute Teacher', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'42f728ca-8072-4b75-9fe5-ef92a164b9a2', N'Hospitalist', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'e54fc5d8-e268-43ac-9dd1-f49d947a3e83', N'Teacher', N'b0628aa6-e8c8-4b7a-9d29-0af9a2562efc')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'267ba088-3b28-4b60-943d-f5cff228013e', N'Software Developer', N'9ed88fca-beec-4bb4-abf2-3282fa5b0011')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'8ea7e6da-e9b3-424e-8a65-fbc87275ca9f', N'Aircraft Mechanic', N'60b73baa-1375-46f1-8c7e-f0de498e4c51')
INSERT [dbo].[SubIndustries] ([Id], [Name], [IndustryId]) VALUES (N'2c16eafa-239e-47f0-974c-ff252be90a31', N'Veterinarian', N'c076f17e-8e4a-4ef0-89f0-7da5e2256849')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [JobId]) VALUES (N'a4e8e3ae-d1f4-4bbe-aed0-2a20f34d9d7c', N'tsveti.zlateva@gmail.com', N'TSVETI.ZLATEVA@GMAIL.COM', N'tsveti.zlateva@gmail.com', N'TSVETI.ZLATEVA@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJrsmoDRcQ9d8rrj3+8qhXNtT8VzmBeTf5OgmbqNZMPjiEeq3V/AgnMKPlOJF+UsJA==', N'K474L4ILMCX7CCTKQT7S5DODTNJBFZ2P', N'15931693-91ce-4501-98fe-c20768e7819d', NULL, 0, 0, NULL, 1, 0, NULL)
  insert into [AspNetUserRoles]
  values
  ('a4e8e3ae-d1f4-4bbe-aed0-2a20f34d9d7c', '240957A5-DC23-4B7A-AA2E-84636771ED73')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ba3f205b-043c-4e37-bf07-00f491ab3de0', N'Aytos')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'1c496038-46c1-4723-a08f-014f6c856604', N'Ivaylovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6672d39a-3c1a-4374-bd1a-01aaa4c33d22', N'Kostandovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5263df64-433b-4c28-a658-027ed8be08a7', N'Vidin')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8ecebc04-c9a8-442d-a3e3-058984fac663', N'Teteven')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'406fd167-e472-4f85-867c-0641df9457f7', N'Yambol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5ac55b86-bee4-4200-8168-074fade8fcf3', N'Razlog')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'fabd3765-f856-4062-a030-091e4ab05e1e', N'Haskovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6d171a9a-f6b3-493e-bb9d-0936008deab0', N'Shabla')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ea23eda1-a4e9-4d10-a2f2-09d876197ea4', N'Batak')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd8aaf965-d070-4913-a4dc-0bbf387030ee', N'Zlatitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c77302bb-3ae5-40d1-b8a6-0c7ec0390689', N'Harmanli')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'46dba0b3-017d-4214-ac49-0c98e87ea19c', N'Smolyan')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'10a19808-300e-4ba0-928a-0f338e6daa01', N'Godech')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c3ed140d-8bab-4a39-802f-1121291cb18f', N'Novo Selo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8cfa8ab8-4836-4a18-8ce7-11836ef86141', N'Radnevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'23b7dc90-f142-4427-8e1b-118c66ae1732', N'Roman')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ca48cbef-c648-434c-a658-126c92dbd62f', N'Panagyurishte')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5bc8d4ca-2ee4-4cfa-a950-15f41dad88dd', N'Pavlikeni')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7a48e833-b36d-4479-b18a-1615c0de98ad', N'Gulyantsi')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'799e2b62-1e64-4c51-845c-17a292284a77', N'Loznitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'088fa915-4267-446b-a774-18da184ce37b', N'Sungurlare')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e08a1f1d-68a7-4d95-a9e8-18df9608c0db', N'Belitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'0c4e1eb2-9ed4-4b04-b73e-19bbd7f6c501', N'Sandanski')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b4e5900d-f36f-4077-932d-19f149ddd4c1', N'Kuklen')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'bd861e47-d300-4c40-a25a-1a39753cc0d3', N'Petrich')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8f4f08d1-5535-46d3-a37b-1c09eabf0be0', N'Aksakovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'738cfd96-df30-4b8e-bdbe-1c53f525ca43', N'Velingrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'93d23765-74a8-4ac1-b7b7-1d10cf007e8c', N'Varna')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd9ee055c-dd1b-4b61-a2c9-1d7a79277562', N'Borino')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e8e0c347-1916-443f-b14c-1ece373de44a', N'Veliki Preslav')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'105ca933-7e0c-4dc1-8dc2-20fff882e2dd', N'Bankya')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8354832c-6dc8-4cad-a7e8-25ef24105a75', N'Peshtera')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'cb9346a9-8540-4c81-a139-27a59b2f8853', N'Drenovets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'750d047d-a128-446d-a4b9-27abebed0759', N'Shiroka Laka')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f4edd521-be35-477f-9033-29824977ee84', N'Smyadovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7c612455-6a78-4f91-9f96-2a4ba6f40031', N'Polski Trambesh')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'37c3e031-689d-4349-8bba-2b8a97ca3ba8', N'Nikopol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4e21a184-697e-4cf6-8c08-2bec92f5107e', N'Gabrovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b61b2ebf-5180-405c-95b2-2eabf9782819', N'Asenovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a7ef1d4b-d6e6-473b-b653-31884f182bc0', N'Kirkovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'be461c29-4376-4889-b48c-32b7f078edcc', N'Rakovski')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd7c3f148-f115-42e8-ac8b-33876761f773', N'Primorsko')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'3986a2f3-7f08-42af-9ad4-342ad7b81ae0', N'Elhovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'090e106e-c998-4567-a38c-35679b8abd8d', N'Krushari')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6afd6cbf-225d-42ce-8d05-3568ee83ac00', N'Tvarditsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'685e252d-d4ee-4445-bf65-35c68b72fd05', N'Kostinbrod')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4b16e8e9-64a3-405c-88c8-36a1126b9020', N'Kresna')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6a2329ff-4bbd-4743-887a-393500632814', N'Boychinovtsi')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'764af5f8-96fe-473e-9a8e-3955fb03f2a2', N'Etropole')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'aa70c9df-61de-4ec6-b1c3-39dcf0df77cc', N'Kalofer')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'3d069cc1-4c53-47b2-a842-3bebcb395540', N'Simeonovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'91438f0b-cb18-4ff0-bbdf-421869ac9d87', N'Burgas')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'bca7e1a6-7617-41bb-b145-424831e800f9', N'Dulovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'993e7ff1-50bf-438c-8899-43ddcfab48b4', N'Bregovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4cf9aae4-bc82-4ea8-9c62-4556542edb06', N'Medkovets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'70a29e50-d821-4aa1-b670-483691858c7c', N'Belogradchik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b3bb0f0c-398c-436d-9f66-484a70b4845e', N'Radomir')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'76acf837-a2b5-4dbc-b552-4b0f8cf3d9ba', N'Pazardzhik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd06cc4b1-e48a-4efb-8ec3-4c64f819deef', N'Dolna Mitropolia')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'804a9713-76cd-4127-88de-4d3429025002', N'Perushtitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c45771d0-d7e1-41a0-9cc3-4e673564d65a', N'Straldzha')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'89d47960-3796-4821-bddd-4f46aba9e29b', N'Byala')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'183bdc76-8b74-4246-aec0-4fa1bd0577ea', N'Botevgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7385191d-2655-4a1b-a7c7-50787f5d1822', N'Blagoevgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2bd5a0d7-45ab-460a-a3b3-52cb2e215a8b', N'Makresh')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'97ebe9cd-f858-4a41-b510-58ca10c5da50', N'Ruzhintsi')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5292a63f-2870-4052-9da4-591a756af430', N'Sliven')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e0f5adfe-c020-47c5-876b-5a230ef5da8d', N'Sevlievo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'9c210ce3-81dd-4577-a90d-5a2ed5e23cda', N'Lukovit')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7edc996c-6c40-4dfa-865f-5a9994133e1e', N'Hayredin')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'bbbd6cf4-7f99-4dc8-9b2c-5b06756a4500', N'Dryanovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'654e5ce5-2254-4aa5-bd3c-5eae01060aee', N'Kostenets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ae0bbade-4798-4464-897c-601034de8c19', N'Karnobat')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'cd169470-dc2d-4c82-9cec-60d2bc71b766', N'Rakitovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c000066b-f376-4491-84dd-6314dea9ee72', N'Shivachevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ec542509-a560-473b-b832-6342bb491d14', N'Trastenik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c179a12a-63a6-4f74-b2c8-659aed6e0e1d', N'Zavet')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'01868940-b3d8-418c-a20d-66fca9cb9d5b', N'Debelets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ab7942d5-373b-44de-81db-6721ea33898b', N'Omurtag')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8b4ee37b-3ce5-41da-86a5-67894765c4ef', N'Beloslav')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'16def5d3-a512-438c-a491-68df88343e47', N'Kula')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f77bd566-5fb7-445d-ba83-68e1263388cc', N'Valchedram')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c485dc5a-76ae-4c66-8833-6923f9bd5fc6', N'Dolni Chiflik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'dd0fa0bd-4f45-40cf-83fc-69cb195b9a22', N'Elena')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f294754c-3845-46bf-bf20-69ef569c22d9', N'Lyaskovets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'84a9e89b-acd4-4936-9c21-6a2aaf2f5361', N'Dobrich')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f1fdc0c3-3ee8-435c-82f5-6b6f33d6bb5e', N'Dimitrovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'06030214-b249-496b-9907-6bc2784ba691', N'Spasovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'18dd51e7-ef11-49ca-ade4-6bd2ba324ee2', N'Montana')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8f4d672d-2946-4b4c-82f2-6be42e0d8265', N'Sarnitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'09f51da1-e01a-4b3e-ac2e-6bfeb5c5263b', N'Sozopol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'bce2c1fe-3c0d-4ff6-8450-6c4b71d3ee9a', N'Kubrat')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'9369d233-97b8-4f5e-bcae-6cb3b1466ac1', N'Dalgopol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4ee4fd49-8827-4c94-9dc2-6e4a4a1f1444', N'Svilengrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8a95acc5-0a90-4196-becb-7188ac834847', N'Shumen')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a4a9f606-aa88-4084-bf48-732edf5148e9', N'Maglizh')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd416de22-953d-476a-870e-7755b450c3b3', N'Popovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f360c1eb-2ced-43ec-9006-79413f71393f', N'Dospat')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5dfca971-6f44-4e0e-a9dc-794c314bd85a', N'Pirdop')
GO
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'17842a65-e7be-45aa-b401-7aef10180c22', N'Sitovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'39e62ce5-70d4-4d6c-9354-7bbabf20f499', N'Kaolinovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5e6039f5-ccbb-4b5e-a8bf-7c581c4b1a1c', N'Nikolaevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f92d8572-acab-4d09-9bcd-7c6128c63f16', N'Pomorie')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7d4a8d68-e046-4fc2-b467-7c617d3c2e8b', N'Provadia')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'646f6f9f-4ff7-445b-9e40-7c7ab2fc35c5', N'Lom')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e767a212-3039-492f-9717-7c7d14e51296', N'Momchilgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'184d7b54-3d32-4198-bf75-7d090daefc31', N'Nedelino')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'292b15fd-5ab3-40d6-9f14-7d13f4603967', N'Oryahovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4b5c6f01-e4c8-41d7-aad7-7e16c5f29183', N'Belene')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6fe73a16-c2b1-40ae-9124-7ee15d04ff0a', N'Dobrinishte')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'063c1816-3e81-4b76-a5b6-802b8a55da68', N'Ardino')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b0732f9f-864b-4539-a108-806a39dffd15', N'Karlovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6b735b83-7484-45df-a7de-83c49aec92d2', N'Breznik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'90edea39-8327-4719-8169-84f319abd6ce', N'Suvorovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'3cf761af-be56-4107-909b-85d481d4c74b', N'Knezha')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e67d3d5d-c5fa-45e2-be81-8689b277d6dd', N'Lovech')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'371891d0-35c2-4d9a-8704-87537437ec03', N'Dzhebel')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'828314be-80ca-4280-91c4-887d00e3ac25', N'Iskar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c22fa6a5-b601-4b23-b243-89891d2153d6', N'Gorna Oryahovitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'1998df7f-65c5-4015-b75e-8a120f2d4ae6', N'Dolni Dabnik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a3dfe97d-86b6-4be1-a9a3-8ac4126f1c85', N'Tervel')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'9c0c9d57-760e-4a3b-940a-8c9f651b093a', N'Septemvri')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ffdfd4ca-d4ca-41dc-9a64-8e94f97c68af', N'Pleven')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'884ffeb4-26ad-4ac3-adf1-8f924f8f2f5f', N'Kazanlak')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ff1a63a5-05ad-4dcd-86e0-8fc10fd1f3ad', N'General Toshevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'aa8ac1c3-9a8e-4197-ab26-90179dc16139', N'Ihtiman')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'42483a1b-9c54-4124-bed4-903a4b682139', N'new')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'382606ec-8aae-4a35-a26c-908d834bdd2d', N'Dupnitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'87a2ec46-1ffa-426f-a6b0-909094e6632a', N'Plovdiv')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'510ae513-5e8e-446c-8ec7-90d888832127', N'Kotel')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'30069c69-37ab-46f8-90b9-913422595ef3', N'Samokov')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2c960be9-6432-488e-9fc8-9142ec9b2cfd', N'Kran')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd9d5e509-d82a-4bf4-878b-92516ee912b8', N'Pravets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7b0d96bf-1813-45f3-96d9-9438d42066fb', N'Kameno')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8cce736a-8e92-45ec-995a-9500028a45e3', N'Zlatograd')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8fb1a3b8-16c3-4f29-b27d-96fa75794679', N'Letnitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'1c4cd133-fc55-45d8-81b5-9b43afac4036', N'Bansko')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e4fdceed-5f53-4b3b-aa3e-9ef4615e18bd', N'Stamboliyski')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'06a0eb5b-fc51-49c7-87b7-a11ca4a4b9e5', N'Nevestino')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'97828a21-7898-4746-a939-a1e30b5ddf07', N'Devnya')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'10cc1a38-73a7-4e86-b05c-a313b0cca27a', N'Valchidol ')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'71d43888-9f59-4eb3-8bde-a44a72fe11f1', N'Gurkovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ef45e0b6-7db9-4139-86ac-a60bbf7b8a93', N'Ivanovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd4eb6b2b-b8e2-4d74-b382-a6e7f5a9fc82', N'Varshets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e03a341f-d1c8-448b-8dec-a756f5d0ac72', N'Veliko Tarnovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'55cab632-de1b-4307-b657-a86f9d63e0b0', N'Novi Pazar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'fdec8a3c-873f-4e72-97a3-aa48884b1264', N'Sofia')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'9b7ce6ee-4a16-4a83-8f19-aa4d83512f32', N'Rudozem')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'3a6738e1-af6c-4ad8-b0ea-abd9dd89cc29', N'Kyustendil')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'41d11c8b-0983-4d55-aee5-acacc1492cda', N'Novi Iskar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2a9ad79d-ab1e-48b0-ad6f-ad9718e8a8d3', N'Kableshkovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4df6c357-b190-4a79-8137-af8c1c9079fb', N'Ignatievo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'46f51e31-a8ee-4dff-89d9-afc8ffae548a', N'Krichim')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'1c22a147-e42f-418e-a9e8-b0a6363fa69b', N'Nova Zagora')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8539d541-a549-4c80-b1d7-b37b0b10758c', N'Slivnitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a3e8603c-e0b1-4c5a-a09c-b49a2cd0b73c', N'Bratsigovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8806d3f6-72b9-48a9-ad66-b572e0f41ec6', N'Bozhurishte')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'397c9de0-6330-4dc0-903e-b5ada0317fe1', N'Vratsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'bc0b50c4-3ead-4a07-bbdb-b928524be37f', N'Koynare')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c6da0626-645a-4517-9c85-b9cc46d7841b', N'Sredets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'85026448-a59f-4c11-9a33-bc7d14201b50', N'Yakoruda')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c1cff294-a7dd-41ef-83ce-bcc5de6dc9c2', N'Elin Pelin')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b9bb396f-f7e7-4aa7-a2a9-bd810efefbae', N'Strazhitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'71f78960-b9d0-48fb-847b-bec705eeaa27', N'Silistra')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2cc08d9c-e3cf-4825-b45f-bed6b54269e9', N'Dve Mogili')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4f1d75c4-38cf-4156-92d1-c0676266b4dc', N'Svoge')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a78759ab-aba7-42cc-8e81-c0ee6ded29f7', N'Krivodol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8b4c8a35-13ca-45c4-b18e-c162094f173d', N'Svishtov')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'0fe815ad-078c-47d2-b4c8-c22db656a54d', N'Dimovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ae624a14-4f24-45b3-bda7-c396d9160ebc', N'Kardzhali')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'809a85fd-37dd-4129-8194-c60276ba2255', N'Tsarevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'03def784-ffe8-44f4-bfb3-c7696e7b55e2', N'Devin')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'89278414-48f9-4ebf-b24d-c7e36729ba38', N'Lyubimets')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'19d5ecd8-5d54-4ebd-8fef-ca2d2e2c9b5f', N'Gotse Delchev')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b908b448-b9ef-4ccd-a0cd-cd05bcf350ce', N'Nesebar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ea086764-d641-4993-b90d-ce0d4063eaac', N'Parvomay')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'baf6e1b7-3f5e-477c-9d0f-d10bc495d48a', N'Kavarna')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6c6a58ea-9474-4f3f-9cc7-d15c542b0fb3', N'Tryavna')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'f31f4c54-4927-49a5-9999-d1afc766d782', N'Iskar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'60deaa4a-319c-41d0-9b6b-d37ab4e03faa', N'Marten')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd33d5f73-2ec9-49af-b423-d4c1b227504d', N'Stara Zagora')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2af8a7e0-3075-45ad-a92a-d58b7a1c5410', N'Pavel Banya')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd6a9105c-bf0d-4ae0-9b24-d7461f77fe45', N'Troyan')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'2bb08557-a912-46ea-b289-d74c0016c7c7', N'Mezdra')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'495a5338-b068-4642-834a-d9f9f05be5e2', N'Isperih')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'eec69e59-70e6-45ce-835a-da0c82a10d2f', N'Belovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7f4f58ca-a5d8-488e-a8fa-da877fdfe2a8', N'Dolna Oryahovitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'a33bfd32-fadb-446a-97cd-da93dcff2438', N'Kaynardzha')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c6bb7d7f-9ac0-4015-8450-dabcf7004938', N'Chepelare')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'008f7878-d45f-4cb0-92d1-dd15a1d395bf', N'Simitli')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'394faa09-92a2-4cb3-8cb8-dd3e239fe892', N'Zlataritsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'1a494889-f337-40f4-8f6b-dd52328d48c4', N'Ruse')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ea2a1480-10aa-4d70-868e-dfb85133647e', N'Pernik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'eb2d448e-9f24-4a2b-8151-dfd541badfbd', N'Gramada')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c06473d8-d95b-4627-8a77-e052dee7ef97', N'Strelcha')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ac2ef0af-697a-434d-b968-e088e570ecda', N'Chuprene')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'6e1d9214-ba92-4cb8-905b-e0d64481cf1f', N'Vetovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'344b3df5-ae90-46dd-a164-e1541d4b949a', N'Varbitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'0ee4f65a-2c3d-491a-82ca-e1b612ffa69a', N'Dragoman')
GO
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd3ea7eb9-03ec-4acc-b034-e1b7fae02a82', N'Krumovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'221008b7-9ef6-4d84-92d2-e351171fddc4', N'Balchik')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'22c89c23-9470-4105-a192-e424bbc42e10', N'Targovishte')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'5f1736e8-70f1-48cc-837b-e4db383bb18f', N'Mizia')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7c752dd1-5a72-4570-bf95-e685514b4c1a', N'Hadzhidimovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'0828d70e-26bc-43cd-8244-e7694835b445', N'Boynitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'b81c1715-52fc-4655-874c-e7b7b65f6595', N'Sveti Vlas')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'26124dd7-c1a2-4522-b09c-e7f4094df065', N'Byala Slatina')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ecdb6ad7-2024-4480-af82-e8330679826e', N'Tran')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'552110f4-a4e3-4e55-a899-ea279d0352cf', N'Madan')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'3e58851d-70d6-41fd-9ef9-ecd3a29ea92b', N'Topolovgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4ae49ba7-a36e-42ee-8bb7-ed9e4d7ae769', N'Chirpan')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'ab00985f-72c3-4768-8f93-edadad22bc8d', N'Alfatar')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'e81762cf-c6c1-43e1-aee7-eddc8cfd7671', N'Tutrakan')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'944fc43b-bb9f-46e8-a034-ee115c6d22a8', N'Yablanitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'60b282b0-7124-4d09-baf8-ee756e9d02b0', N'Bobov Dol')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'056ba52e-fed0-4c63-b593-eed777222224', N'Borovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd5b29a1c-85a3-4ebf-9bf4-f0a820f9c768', N'Tsenovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'8878a1e2-a2f5-4dd7-a379-f2965f88c059', N'Razgrad')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'd69b3269-2bef-4aa3-82dc-f362db923751', N'Dolna Banya')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'168a5bd4-1e4e-4ff1-9fd5-f56a132cf75f', N'Glodzhevo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'c11b8b12-2784-4290-8116-f5f1fbca7110', N'Berkovitsa')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'dec555d8-e6df-45df-9001-f7a5071c22ea', N'Brusartsi')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'31ad41bf-63b8-458e-a3ab-f8605c214f7c', N'Slavyanovo')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'4a32c630-6e97-44c6-b4bf-f93e5d25de0c', N'new')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'9ca59781-dc82-4775-bfdd-fc7d5e2c0806', N'Kozloduy')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7fbba97e-77f0-453f-be7a-ff06515aee7d', N'Sapareva Banya')
INSERT [dbo].[Locations] ([Id], [Name]) VALUES (N'7b64bc73-b9e4-4af2-87b1-ff29f7da35d6', N'Slivo Pole')
