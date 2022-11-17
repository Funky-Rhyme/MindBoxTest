SELECT
	P.Product,
	C.Category
FROM 
	dbo.Products AS P
LEFT JOIN
	dbo.ProductsCategories PC ON P.id = PC.ProductId
LEFT JOIN
	dbo.Categories C ON C.id = PC.CategoryId
