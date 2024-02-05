## :books:Layers  
## Entities Layer
Veritabanı nesneleri için oluşturulmuş **Entities Katmanı**'nda **Abstract** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 ~~IEntity.cs~~ (Ortak Kod Olduğu İçin Core Katmanına Aktarıldı.)
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [Person.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Entities/Concrete/Person.cs)  
<br>
##  Business Layer
Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan **Business Katmanı**'nda **Abstract**,**Concrete** olmak üzere iki adet klasör bulunmaktadır.Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.  
<br>:file_folder:`Abstract`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [IApplicantService.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Business/Abstract/IApplicantService.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [ISupplierService.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Business/Abstract/ISupplierService.cs)  
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [PersonManager.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Business/Concrete/PersonManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [PttManager.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Business/Concrete/PttManager.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📄 [ForeignerManager.cs](https://github.com/ibrahimalzamel/MaskeTakip/blob/master/Business/Concrete/ForeignerManager.cs)    
