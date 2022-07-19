select categories.name, sum(Products.amount) as Sum from products
inner join categories on (products.id_categories = categories.id)
group by categories.name
order by categories.name asc
