select prod.name, prov.name, cat.name
from products prod
inner join providers prov on (prod.id_providers = prov.id)
inner join categories cat on (prod.id_categories = cat.id)
where prov.name = 'Sansul SA' and cat.name = 'Imported'
