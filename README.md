
![Logo](https://mk0hitconsultan2lp7c.kinstacdn.com/wp-content/uploads/2020/03/Supply-Chain-Cornavirus-covid-19.png)

    
# Supply

Bu projede WebAPI bestpractise'lerini uygulamaya çalıştım.

Bu proje tedarik bilgilerini kayıt altına alır.

Müşterilerin alışveriş bilgilerini ve geçmiş tedarik bilgilerinin kolayca görüntülenmesi, tüm tedarik bilgilerinin kayıt altına alınarak veriler üretilmesi amaçlanmaktadır.


## Kullanılan Teknoloji Ve Teknikler

Asp.Net Core for Restful api\
MsSql\
EntityFramework Core

OOP\
SOLID principles\
Layered Architecture Design Pattern\
Repository Pattern\
Dependency injection\
IOC Containers

<!-- <summary><h2>API Kullanımı</h2></summary> -->
## API Kullanımı
<details open>

#### Customers

| HTTP Verb | Route | POST body | Description |
| --- | --- | --- | --- |
| `GET` | /api/Customer |  Empty | List all customers. |
| `POST` | /api/Customer | {"id": 0,"name": "string","companyName": "string","phoneNumber": "string","address": "string"} | Create a new customer. |
| `DELETE` | /api/Customer |  { "id": 0, "name": "string", "companyName": "string", "phoneNumber": "string", "address": "string" } | Delete a customer. |
| `PUT` | /api/Customer |  { "id": 0, "name": "string", "companyName": "string", "phoneNumber": "string", "address": "string" } | Update a customer with new info. |
| `GET` | ​/api​/Customer​/{id} |  Empty | Get a customer. |


#### PaymentDetails

| HTTP Verb | Route | POST body | Description |
| --- | --- | --- | --- |
| `GET` | /api/PaymentDetails |  Empty | List all PaymentDetails. |
| `POST` | /api/PaymentDetails | { "id": 0, "supplyId": 0, "previousDept": 0, "recievedMoney": 0, "remainingDept": 0 } | Create a new PaymentDetail. |
| `DELETE` | /api/PaymentDetails |  { "id": 0, "supplyId": 0, "previousDept": 0, "recievedMoney": 0, "remainingDept": 0 } | Delete a PaymentDetail. |
| `PUT` | /api/PaymentDetails |  { "id": 0, "supplyId": 0, "previousDept": 0, "recievedMoney": 0, "remainingDept": 0 } | Update a PaymentDetail with new info. |
| `GET` | ​/api​/PaymentDetails​/{id} |  Empty | Get a PaymentDetail. |
| `GET` | /api/PaymentDetails/GetAllWithSupplyDetail |  Empty | Get All PaymentDetails With SupplyDetails. |
| `GET` | /api/PaymentDetails/GetByIdWithSupplyDetail/{id} |  Empty | Get a PaymentDetail With SupplyDetail. |


#### Product

| HTTP Verb | Route | POST body | Description |
| --- | --- | --- | --- |
| `GET` | /api/Product |  Empty | List all Products. |
| `POST` | /api/Product | { "id": 0, "name": "string", "unitPrice": 0, "unitsInStock": 0 } | Create a new Product. |
| `DELETE` | /api/Product |  { "id": 0, "name": "string", "unitPrice": 0, "unitsInStock": 0 } | Delete a Product. |
| `PUT` | /api/Product |  { "id": 0, "name": "string", "unitPrice": 0, "unitsInStock": 0 } | Update a Product with new info. |
| `GET` | ​/api​/Product​/{id} |  Empty | Get a Product. |


#### Supply

| HTTP Verb | Route | POST body | Description |
| --- | --- | --- | --- |
| `GET` | /api/Supply |  Empty | List all Supplys. |
| `POST` | /api/Supply | { "id": 0, "customerId": 0, "supplyDate": "2021-10-10T01:49:54.142Z", "totalPrice": 0 } | Create a new Supply. |
| `DELETE` | /api/Supply |  { "id": 0, "customerId": 0, "supplyDate": "2021-10-10T01:49:54.142Z", "totalPrice": 0 } | Delete a Supply. |
| `PUT` | /api/Supply |  { "id": 0, "customerId": 0, "supplyDate": "2021-10-10T01:49:54.142Z", "totalPrice": 0 } | Update a Supply with new info. |
| `GET` | ​/api​/Supply​/{id} |  Empty | Get a Supply. |


#### SupplyDetail

| HTTP Verb | Route | POST body | Description |
| --- | --- | --- | --- |
| `GET` | /api/SupplyDetail |  Empty | List all SupplyDetails. |
| `POST` | /api/SupplyDetail | { "id": 0, "supplyId": 0, "productId": 0, "quantity": 0, "unitPrice": 0 } | Create a new SupplyDetail. |
| `DELETE` | /api/SupplyDetail |  { "id": 0, "supplyId": 0, "productId": 0, "quantity": 0, "unitPrice": 0 } | Delete a SupplyDetail. |
| `PUT` | /api/SupplyDetail |  { "id": 0, "supplyId": 0, "productId": 0, "quantity": 0, "unitPrice": 0 } | Update a SupplyDetail with new info. |
| `GET` | ​/api​/SupplyDetail​/{id} |  Empty | Get a SupplyDetail. |
| `GET` | ​/api/SupplyDetail/GetAllWithDetail |  Empty | Get all SupplyDetail With Details. |
| `GET` | ​/api/SupplyDetail/GetByIdWithDetail/{id} |  Empty | Get a SupplyDetail With Details. |
</details>

## Bilgisayarınızda Çalıştırın

Projeyi klonlayın

```bash
  git clone https://github.com/MustafaCelal/Supply.git
```

Proje dizinine gidin

```bash
  cd Supply
```

Gerekli paketleri yükleyin

```dotnet cli
  dotnet restore
```

Sunucuyu çalıştırın

```dotnet
  dotnet run
```

  
## Geri Bildirim

Katkılara ve Geri Bildirimlere her zaman açığım!

Herhangi bir geri bildiriminiz varsa, lütfen m.cllglr@gmail.com adresinden bana ulaşın.
## İlişkili Projeler

Çok yakında Front-End projesi de gelecek takipte kalınız :)

[Supply_Front-End](https://github.com/MustafaCelal/Supply_Front-End)
## Lisans

[MIT](https://choosealicense.com/licenses/mit/)
