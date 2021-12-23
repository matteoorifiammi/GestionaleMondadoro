# Schema input e Output metodi - Software Gestionale "Mondadoro"
### Gestionale di un punto vendita - Modalità ASP.NET Web Forms

## Magazzino:

### Classe `Product`:

#### Metodi:
- `searchProduct(productId)` -> productQuantity
- `addProduct(productId, quantityAdd)` ->  productQuantity
- `removeProduct(productId, quantityRemove)` ->  productQuantity
- `createProduct(name, listPrice, sellingPrice, productQuantity)` -> void
- `deleteProduct(productId)` -> void
##

## Organico:

### Classe `Person`:
- `createPerson(name, role, wage)` -> void
- `deletePerson(badgeNumber)` -> void 
- `searchPerson(badgeNumber)` -> personInfo
##

## Finanze:

#### Metodi:
- `showBalance()` -> balance
---
###### Matteo Orifiammi (PM); Angelo Pavan; Simone Giuriato; Federico Rossi - 4F - 23/12/2021
