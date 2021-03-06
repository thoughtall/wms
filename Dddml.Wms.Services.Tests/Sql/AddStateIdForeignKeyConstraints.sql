﻿alter TABLE `AttributeValues` add
  CONSTRAINT `FK_AttributeValue_Attribute_StateId` 
  FOREIGN KEY 
    (`AttributeValueIdAttributeId`) 
  REFERENCES `Attributes` 
    (`AttributeId`) 
  ON DELETE NO ACTION ON UPDATE NO ACTION;

alter TABLE `AttributeUses` add
  CONSTRAINT `FK_AttributeUse_AttributeSet_StateId` 
  FOREIGN KEY 
    (`AttributeSetAttributeUseIdAttributeSetId`) 
  REFERENCES `AttributeSets` 
    (`AttributeSetId`) 
  ON DELETE NO ACTION ON UPDATE NO ACTION;

alter TABLE `InOutLines` add
  CONSTRAINT `FK_InOutLine_InOut_StateId` 
  FOREIGN KEY 
    (`InOutLineIdInOutDocumentNumber`) 
  REFERENCES `InOuts` 
    (`DocumentNumber`) 
  ON DELETE NO ACTION ON UPDATE NO ACTION;

alter TABLE `AttributeSetInstanceExtensionFields` add
  CONSTRAINT `FK_AttributeSetInstanceExtensionField_AttrSetInstEFGroup_StateId` 
  FOREIGN KEY 
    (`AttributeSetInstanceExtensionFieldIdGroupId`) 
  REFERENCES `AttributeSetInstanceExtensionFieldGroups` 
    (`Id`) 
  ON DELETE NO ACTION ON UPDATE NO ACTION;

