SELECT Product.name, Category.name 
  FROM Product
LEFT OUTER JOIN ProductCategory
  ON Product.id = ProductCategory.id_product
LEFT OUTER JOIN Category
  ON ProductCategory.id_category = Category.id
