# ClickSend.Model.RequestAlphaTagRequestBusinessesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **string** |  | 
**BusinessName** | **string** |  | 
**BusinessRelationship** | **string** | Indicates your relationship to the business being registered.  - **PRIMARY**: Your primary business (linked to your ClickSend account). - **ENTITY_ASSOCIATE**: Sending on behalf of another business you represent or own.  | 
**BusinessInfo** | [**RequestAlphaTagRequestBusinessesInnerBusinessInfo**](RequestAlphaTagRequestBusinessesInnerBusinessInfo.md) |  | 
**BusinessAddress** | [**RequestAlphaTagRequestBusinessesInnerBusinessAddress**](RequestAlphaTagRequestBusinessesInnerBusinessAddress.md) |  | 
**Representative** | [**RequestAlphaTagRequestBusinessesInnerRepresentative**](RequestAlphaTagRequestBusinessesInnerRepresentative.md) |  | 
**Abn** | **string** | Australian Business Number (ABN), 11 digits | 
**PartnerBusinessName** | **string** | Partner&#39;s business name. **Required** when &#x60;business_relationship&#x60; is &#x60;ENTITY_ASSOCIATE&#x60;. **Forbidden** otherwise.  | [optional] 
**PartnerAbn** | **string** | Partner&#39;s Australian Business Number (ABN). Must contain only digits. **Required** when &#x60;business_relationship&#x60; is &#x60;ENTITY_ASSOCIATE&#x60;. **Forbidden** otherwise.  | [optional] 
**PartnerBusinessInfo** | [**RequestAlphaTagRequestBusinessesInnerBusinessInfo**](RequestAlphaTagRequestBusinessesInnerBusinessInfo.md) |  | [optional] 
**PartnerBusinessAddress** | [**RequestAlphaTagRequestBusinessesInnerBusinessAddress**](RequestAlphaTagRequestBusinessesInnerBusinessAddress.md) |  | [optional] 
**PartnerRepresentative** | [**RequestAlphaTagRequestBusinessesInnerPartnerRepresentative**](RequestAlphaTagRequestBusinessesInnerPartnerRepresentative.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

