CREATE VIEW View_Customer
AS
SELECT

	-- Grid Fields
		CS.Name					AS	Classification
	,	CM.Name					AS	Customer
	,	CM.Phone
	,	GD.Name					AS	Gender
	,	CT.Name					AS	City
	,	RG.Name					AS	Region
	,	CM.LastPurchase
	,	US.Login				AS	Seller

	-- Ids
	,	CM.Id					AS	CustomerId
	,	CM.GenderId
	,	CM.CityId
	,	CM.RegionId
	,	CM.ClassificationId
	,	CM.UserId				AS	SellerId



FROM		Customer		CM
	JOIN	Classification	CS	ON	CM.ClassificationId	=	CS.Id
	JOIN	Gender			GD	ON	CM.GenderId			=	GD.Id
	JOIN	City			CT	ON	CM.CityId			=	CT.Id
	JOIN	Region			RG	ON	CM.RegionId			=	RG.Id
	JOIN	UserSys			US	ON	CM.UserId			=	US.Id

