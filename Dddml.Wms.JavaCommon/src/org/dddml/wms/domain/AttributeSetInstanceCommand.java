package org.dddml.wms.domain;

import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.Command;

public interface AttributeSetInstanceCommand extends Command
{
    String getAttributeSetInstanceId();

    Long getVersion();


    interface CreateOrMergePatchAttributeSetInstance extends AttributeSetInstanceCommand
    {
        String getAttributeSetId();

        String getOrganizationId();

        String getReferenceId();

        String getSerialNumber();

        String getLot();

        String getDescription();

        String getHash();

        Boolean get_F_B_0_();

        Integer get_F_I_0_();

        Long get_F_L_0_();

        Date get_F_DT_0_();

        BigDecimal get_F_N_0_();

        String get_F_C5_0_();

        String get_F_C10_0_();

        String get_F_C20_0_();

        String get_F_C50_0_();

        String get_F_C100_0_();

        String get_F_C200_0_();

        String get_F_C500_0_();

        String get_F_C1000_0_();

        Boolean get_F_B_1_();

        Integer get_F_I_1_();

        Long get_F_L_1_();

        Date get_F_DT_1_();

        BigDecimal get_F_N_1_();

        String get_F_C5_1_();

        String get_F_C10_1_();

        String get_F_C20_1_();

        String get_F_C50_1_();

        String get_F_C100_1_();

        String get_F_C200_1_();

        String get_F_C500_1_();

        String get_F_C1000_1_();

        Boolean get_F_B_2_();

        Integer get_F_I_2_();

        Long get_F_L_2_();

        Date get_F_DT_2_();

        BigDecimal get_F_N_2_();

        String get_F_C5_2_();

        String get_F_C10_2_();

        String get_F_C20_2_();

        String get_F_C50_2_();

        String get_F_C100_2_();

        String get_F_C200_2_();

        String get_F_C500_2_();

        String get_F_C1000_2_();

        Boolean get_F_B_3_();

        Integer get_F_I_3_();

        Long get_F_L_3_();

        Date get_F_DT_3_();

        BigDecimal get_F_N_3_();

        String get_F_C5_3_();

        String get_F_C10_3_();

        String get_F_C20_3_();

        String get_F_C50_3_();

        String get_F_C100_3_();

        String get_F_C200_3_();

        String get_F_C500_3_();

        String get_F_C1000_3_();

        Boolean get_F_B_4_();

        Integer get_F_I_4_();

        Long get_F_L_4_();

        Date get_F_DT_4_();

        BigDecimal get_F_N_4_();

        String get_F_C5_4_();

        String get_F_C10_4_();

        String get_F_C20_4_();

        String get_F_C50_4_();

        String get_F_C100_4_();

        String get_F_C200_4_();

        String get_F_C500_4_();

        String get_F_C1000_4_();

        Boolean get_F_B_5_();

        Integer get_F_I_5_();

        Long get_F_L_5_();

        Date get_F_DT_5_();

        BigDecimal get_F_N_5_();

        String get_F_C5_5_();

        String get_F_C10_5_();

        String get_F_C20_5_();

        String get_F_C50_5_();

        String get_F_C100_5_();

        String get_F_C200_5_();

        String get_F_C500_5_();

        Boolean get_F_B_6_();

        Integer get_F_I_6_();

        Long get_F_L_6_();

        Date get_F_DT_6_();

        BigDecimal get_F_N_6_();

        String get_F_C5_6_();

        String get_F_C10_6_();

        String get_F_C20_6_();

        String get_F_C50_6_();

        String get_F_C100_6_();

        String get_F_C200_6_();

        String get_F_C500_6_();

        Boolean get_F_B_7_();

        Integer get_F_I_7_();

        Long get_F_L_7_();

        Date get_F_DT_7_();

        BigDecimal get_F_N_7_();

        String get_F_C5_7_();

        String get_F_C10_7_();

        String get_F_C20_7_();

        String get_F_C50_7_();

        String get_F_C100_7_();

        String get_F_C200_7_();

        String get_F_C500_7_();

        Boolean get_F_B_8_();

        Integer get_F_I_8_();

        Long get_F_L_8_();

        Date get_F_DT_8_();

        BigDecimal get_F_N_8_();

        String get_F_C5_8_();

        String get_F_C10_8_();

        String get_F_C20_8_();

        String get_F_C50_8_();

        String get_F_C100_8_();

        String get_F_C200_8_();

        String get_F_C500_8_();

        Boolean get_F_B_9_();

        Integer get_F_I_9_();

        Long get_F_L_9_();

        Date get_F_DT_9_();

        BigDecimal get_F_N_9_();

        String get_F_C5_9_();

        String get_F_C10_9_();

        String get_F_C20_9_();

        String get_F_C50_9_();

        String get_F_C100_9_();

        String get_F_C200_9_();

        String get_F_C500_9_();

        Boolean get_F_B_10_();

        Integer get_F_I_10_();

        Long get_F_L_10_();

        Date get_F_DT_10_();

        BigDecimal get_F_N_10_();

        String get_F_C5_10_();

        String get_F_C10_10_();

        String get_F_C20_10_();

        String get_F_C50_10_();

        String get_F_C100_10_();

        String get_F_C200_10_();

        Boolean get_F_B_11_();

        Integer get_F_I_11_();

        Long get_F_L_11_();

        Date get_F_DT_11_();

        BigDecimal get_F_N_11_();

        String get_F_C5_11_();

        String get_F_C10_11_();

        String get_F_C20_11_();

        String get_F_C50_11_();

        String get_F_C100_11_();

        String get_F_C200_11_();

        Boolean get_F_B_12_();

        Integer get_F_I_12_();

        Long get_F_L_12_();

        Date get_F_DT_12_();

        BigDecimal get_F_N_12_();

        String get_F_C5_12_();

        String get_F_C10_12_();

        String get_F_C20_12_();

        String get_F_C50_12_();

        String get_F_C100_12_();

        String get_F_C200_12_();

        Boolean get_F_B_13_();

        Integer get_F_I_13_();

        Long get_F_L_13_();

        Date get_F_DT_13_();

        BigDecimal get_F_N_13_();

        String get_F_C5_13_();

        String get_F_C10_13_();

        String get_F_C20_13_();

        String get_F_C50_13_();

        String get_F_C100_13_();

        String get_F_C200_13_();

        Boolean get_F_B_14_();

        Integer get_F_I_14_();

        Long get_F_L_14_();

        Date get_F_DT_14_();

        BigDecimal get_F_N_14_();

        String get_F_C5_14_();

        String get_F_C10_14_();

        String get_F_C20_14_();

        String get_F_C50_14_();

        String get_F_C100_14_();

        String get_F_C200_14_();

        Boolean get_F_B_15_();

        Integer get_F_I_15_();

        Long get_F_L_15_();

        Date get_F_DT_15_();

        BigDecimal get_F_N_15_();

        String get_F_C5_15_();

        String get_F_C10_15_();

        String get_F_C20_15_();

        String get_F_C50_15_();

        String get_F_C100_15_();

        String get_F_C200_15_();

        Boolean get_F_B_16_();

        Integer get_F_I_16_();

        Long get_F_L_16_();

        Date get_F_DT_16_();

        BigDecimal get_F_N_16_();

        String get_F_C5_16_();

        String get_F_C10_16_();

        String get_F_C20_16_();

        String get_F_C50_16_();

        String get_F_C100_16_();

        String get_F_C200_16_();

        Boolean get_F_B_17_();

        Integer get_F_I_17_();

        Long get_F_L_17_();

        Date get_F_DT_17_();

        BigDecimal get_F_N_17_();

        String get_F_C5_17_();

        String get_F_C10_17_();

        String get_F_C20_17_();

        String get_F_C50_17_();

        String get_F_C100_17_();

        String get_F_C200_17_();

        Boolean get_F_B_18_();

        Integer get_F_I_18_();

        Long get_F_L_18_();

        Date get_F_DT_18_();

        BigDecimal get_F_N_18_();

        String get_F_C5_18_();

        String get_F_C10_18_();

        String get_F_C20_18_();

        String get_F_C50_18_();

        String get_F_C100_18_();

        String get_F_C200_18_();

        Boolean get_F_B_19_();

        Integer get_F_I_19_();

        Long get_F_L_19_();

        Date get_F_DT_19_();

        BigDecimal get_F_N_19_();

        String get_F_C5_19_();

        String get_F_C10_19_();

        String get_F_C20_19_();

        String get_F_C50_19_();

        String get_F_C100_19_();

        String get_F_C200_19_();

        Boolean get_F_B_20_();

        Integer get_F_I_20_();

        Long get_F_L_20_();

        BigDecimal get_F_N_20_();

        String get_F_C5_20_();

        String get_F_C10_20_();

        String get_F_C20_20_();

        String get_F_C50_20_();

        Boolean get_F_B_21_();

        Integer get_F_I_21_();

        Long get_F_L_21_();

        BigDecimal get_F_N_21_();

        String get_F_C5_21_();

        String get_F_C10_21_();

        String get_F_C20_21_();

        String get_F_C50_21_();

        Boolean get_F_B_22_();

        Integer get_F_I_22_();

        Long get_F_L_22_();

        BigDecimal get_F_N_22_();

        String get_F_C5_22_();

        String get_F_C10_22_();

        String get_F_C20_22_();

        String get_F_C50_22_();

        Boolean get_F_B_23_();

        Integer get_F_I_23_();

        Long get_F_L_23_();

        BigDecimal get_F_N_23_();

        String get_F_C5_23_();

        String get_F_C10_23_();

        String get_F_C20_23_();

        String get_F_C50_23_();

        Boolean get_F_B_24_();

        Integer get_F_I_24_();

        Long get_F_L_24_();

        BigDecimal get_F_N_24_();

        String get_F_C5_24_();

        String get_F_C10_24_();

        String get_F_C20_24_();

        String get_F_C50_24_();

        Boolean get_F_B_25_();

        Integer get_F_I_25_();

        Long get_F_L_25_();

        BigDecimal get_F_N_25_();

        String get_F_C5_25_();

        String get_F_C10_25_();

        String get_F_C20_25_();

        String get_F_C50_25_();

        Boolean get_F_B_26_();

        Integer get_F_I_26_();

        Long get_F_L_26_();

        BigDecimal get_F_N_26_();

        String get_F_C5_26_();

        String get_F_C10_26_();

        String get_F_C20_26_();

        String get_F_C50_26_();

        Boolean get_F_B_27_();

        Integer get_F_I_27_();

        Long get_F_L_27_();

        BigDecimal get_F_N_27_();

        String get_F_C5_27_();

        String get_F_C10_27_();

        String get_F_C20_27_();

        String get_F_C50_27_();

        Boolean get_F_B_28_();

        Integer get_F_I_28_();

        Long get_F_L_28_();

        BigDecimal get_F_N_28_();

        String get_F_C5_28_();

        String get_F_C10_28_();

        String get_F_C20_28_();

        String get_F_C50_28_();

        Boolean get_F_B_29_();

        Integer get_F_I_29_();

        Long get_F_L_29_();

        BigDecimal get_F_N_29_();

        String get_F_C5_29_();

        String get_F_C10_29_();

        String get_F_C20_29_();

        String get_F_C50_29_();

        Boolean get_F_B_30_();

        Integer get_F_I_30_();

        BigDecimal get_F_N_30_();

        String get_F_C5_30_();

        String get_F_C10_30_();

        String get_F_C20_30_();

        String get_F_C50_30_();

        Boolean get_F_B_31_();

        Integer get_F_I_31_();

        BigDecimal get_F_N_31_();

        String get_F_C5_31_();

        String get_F_C10_31_();

        String get_F_C20_31_();

        String get_F_C50_31_();

        Boolean get_F_B_32_();

        Integer get_F_I_32_();

        BigDecimal get_F_N_32_();

        String get_F_C5_32_();

        String get_F_C10_32_();

        String get_F_C20_32_();

        String get_F_C50_32_();

        Boolean get_F_B_33_();

        Integer get_F_I_33_();

        BigDecimal get_F_N_33_();

        String get_F_C5_33_();

        String get_F_C10_33_();

        String get_F_C20_33_();

        String get_F_C50_33_();

        Boolean get_F_B_34_();

        Integer get_F_I_34_();

        BigDecimal get_F_N_34_();

        String get_F_C5_34_();

        String get_F_C10_34_();

        String get_F_C20_34_();

        String get_F_C50_34_();

        Boolean get_F_B_35_();

        Integer get_F_I_35_();

        BigDecimal get_F_N_35_();

        String get_F_C5_35_();

        String get_F_C10_35_();

        String get_F_C20_35_();

        String get_F_C50_35_();

        Boolean get_F_B_36_();

        Integer get_F_I_36_();

        BigDecimal get_F_N_36_();

        String get_F_C5_36_();

        String get_F_C10_36_();

        String get_F_C20_36_();

        String get_F_C50_36_();

        Boolean get_F_B_37_();

        Integer get_F_I_37_();

        BigDecimal get_F_N_37_();

        String get_F_C5_37_();

        String get_F_C10_37_();

        String get_F_C20_37_();

        String get_F_C50_37_();

        Boolean get_F_B_38_();

        Integer get_F_I_38_();

        BigDecimal get_F_N_38_();

        String get_F_C5_38_();

        String get_F_C10_38_();

        String get_F_C20_38_();

        String get_F_C50_38_();

        Boolean get_F_B_39_();

        Integer get_F_I_39_();

        BigDecimal get_F_N_39_();

        String get_F_C5_39_();

        String get_F_C10_39_();

        String get_F_C20_39_();

        String get_F_C50_39_();

        Boolean get_F_B_40_();

        Integer get_F_I_40_();

        BigDecimal get_F_N_40_();

        String get_F_C5_40_();

        String get_F_C10_40_();

        String get_F_C20_40_();

        String get_F_C50_40_();

        Boolean get_F_B_41_();

        Integer get_F_I_41_();

        BigDecimal get_F_N_41_();

        String get_F_C5_41_();

        String get_F_C10_41_();

        String get_F_C20_41_();

        String get_F_C50_41_();

        Boolean get_F_B_42_();

        Integer get_F_I_42_();

        BigDecimal get_F_N_42_();

        String get_F_C5_42_();

        String get_F_C10_42_();

        String get_F_C20_42_();

        String get_F_C50_42_();

        Boolean get_F_B_43_();

        Integer get_F_I_43_();

        BigDecimal get_F_N_43_();

        String get_F_C5_43_();

        String get_F_C10_43_();

        String get_F_C20_43_();

        String get_F_C50_43_();

        Boolean get_F_B_44_();

        Integer get_F_I_44_();

        BigDecimal get_F_N_44_();

        String get_F_C5_44_();

        String get_F_C10_44_();

        String get_F_C20_44_();

        String get_F_C50_44_();

        Boolean get_F_B_45_();

        Integer get_F_I_45_();

        BigDecimal get_F_N_45_();

        String get_F_C5_45_();

        String get_F_C10_45_();

        String get_F_C20_45_();

        String get_F_C50_45_();

        Boolean get_F_B_46_();

        Integer get_F_I_46_();

        BigDecimal get_F_N_46_();

        String get_F_C5_46_();

        String get_F_C10_46_();

        String get_F_C20_46_();

        String get_F_C50_46_();

        Boolean get_F_B_47_();

        Integer get_F_I_47_();

        BigDecimal get_F_N_47_();

        String get_F_C5_47_();

        String get_F_C10_47_();

        String get_F_C20_47_();

        String get_F_C50_47_();

        Boolean get_F_B_48_();

        Integer get_F_I_48_();

        BigDecimal get_F_N_48_();

        String get_F_C5_48_();

        String get_F_C10_48_();

        String get_F_C20_48_();

        String get_F_C50_48_();

        Boolean get_F_B_49_();

        Integer get_F_I_49_();

        BigDecimal get_F_N_49_();

        String get_F_C5_49_();

        String get_F_C10_49_();

        String get_F_C20_49_();

        String get_F_C50_49_();

        Boolean getActive();

    }

    interface CreateAttributeSetInstance extends CreateOrMergePatchAttributeSetInstance
    {
    }

    interface MergePatchAttributeSetInstance extends CreateOrMergePatchAttributeSetInstance
    {
        Boolean getIsPropertyAttributeSetIdRemoved();

        Boolean getIsPropertyOrganizationIdRemoved();

        Boolean getIsPropertyReferenceIdRemoved();

        Boolean getIsPropertySerialNumberRemoved();

        Boolean getIsPropertyLotRemoved();

        Boolean getIsPropertyDescriptionRemoved();

        Boolean getIsPropertyHashRemoved();

        Boolean getIsProperty_F_B_0_Removed();

        Boolean getIsProperty_F_I_0_Removed();

        Boolean getIsProperty_F_L_0_Removed();

        Boolean getIsProperty_F_DT_0_Removed();

        Boolean getIsProperty_F_N_0_Removed();

        Boolean getIsProperty_F_C5_0_Removed();

        Boolean getIsProperty_F_C10_0_Removed();

        Boolean getIsProperty_F_C20_0_Removed();

        Boolean getIsProperty_F_C50_0_Removed();

        Boolean getIsProperty_F_C100_0_Removed();

        Boolean getIsProperty_F_C200_0_Removed();

        Boolean getIsProperty_F_C500_0_Removed();

        Boolean getIsProperty_F_C1000_0_Removed();

        Boolean getIsProperty_F_B_1_Removed();

        Boolean getIsProperty_F_I_1_Removed();

        Boolean getIsProperty_F_L_1_Removed();

        Boolean getIsProperty_F_DT_1_Removed();

        Boolean getIsProperty_F_N_1_Removed();

        Boolean getIsProperty_F_C5_1_Removed();

        Boolean getIsProperty_F_C10_1_Removed();

        Boolean getIsProperty_F_C20_1_Removed();

        Boolean getIsProperty_F_C50_1_Removed();

        Boolean getIsProperty_F_C100_1_Removed();

        Boolean getIsProperty_F_C200_1_Removed();

        Boolean getIsProperty_F_C500_1_Removed();

        Boolean getIsProperty_F_C1000_1_Removed();

        Boolean getIsProperty_F_B_2_Removed();

        Boolean getIsProperty_F_I_2_Removed();

        Boolean getIsProperty_F_L_2_Removed();

        Boolean getIsProperty_F_DT_2_Removed();

        Boolean getIsProperty_F_N_2_Removed();

        Boolean getIsProperty_F_C5_2_Removed();

        Boolean getIsProperty_F_C10_2_Removed();

        Boolean getIsProperty_F_C20_2_Removed();

        Boolean getIsProperty_F_C50_2_Removed();

        Boolean getIsProperty_F_C100_2_Removed();

        Boolean getIsProperty_F_C200_2_Removed();

        Boolean getIsProperty_F_C500_2_Removed();

        Boolean getIsProperty_F_C1000_2_Removed();

        Boolean getIsProperty_F_B_3_Removed();

        Boolean getIsProperty_F_I_3_Removed();

        Boolean getIsProperty_F_L_3_Removed();

        Boolean getIsProperty_F_DT_3_Removed();

        Boolean getIsProperty_F_N_3_Removed();

        Boolean getIsProperty_F_C5_3_Removed();

        Boolean getIsProperty_F_C10_3_Removed();

        Boolean getIsProperty_F_C20_3_Removed();

        Boolean getIsProperty_F_C50_3_Removed();

        Boolean getIsProperty_F_C100_3_Removed();

        Boolean getIsProperty_F_C200_3_Removed();

        Boolean getIsProperty_F_C500_3_Removed();

        Boolean getIsProperty_F_C1000_3_Removed();

        Boolean getIsProperty_F_B_4_Removed();

        Boolean getIsProperty_F_I_4_Removed();

        Boolean getIsProperty_F_L_4_Removed();

        Boolean getIsProperty_F_DT_4_Removed();

        Boolean getIsProperty_F_N_4_Removed();

        Boolean getIsProperty_F_C5_4_Removed();

        Boolean getIsProperty_F_C10_4_Removed();

        Boolean getIsProperty_F_C20_4_Removed();

        Boolean getIsProperty_F_C50_4_Removed();

        Boolean getIsProperty_F_C100_4_Removed();

        Boolean getIsProperty_F_C200_4_Removed();

        Boolean getIsProperty_F_C500_4_Removed();

        Boolean getIsProperty_F_C1000_4_Removed();

        Boolean getIsProperty_F_B_5_Removed();

        Boolean getIsProperty_F_I_5_Removed();

        Boolean getIsProperty_F_L_5_Removed();

        Boolean getIsProperty_F_DT_5_Removed();

        Boolean getIsProperty_F_N_5_Removed();

        Boolean getIsProperty_F_C5_5_Removed();

        Boolean getIsProperty_F_C10_5_Removed();

        Boolean getIsProperty_F_C20_5_Removed();

        Boolean getIsProperty_F_C50_5_Removed();

        Boolean getIsProperty_F_C100_5_Removed();

        Boolean getIsProperty_F_C200_5_Removed();

        Boolean getIsProperty_F_C500_5_Removed();

        Boolean getIsProperty_F_B_6_Removed();

        Boolean getIsProperty_F_I_6_Removed();

        Boolean getIsProperty_F_L_6_Removed();

        Boolean getIsProperty_F_DT_6_Removed();

        Boolean getIsProperty_F_N_6_Removed();

        Boolean getIsProperty_F_C5_6_Removed();

        Boolean getIsProperty_F_C10_6_Removed();

        Boolean getIsProperty_F_C20_6_Removed();

        Boolean getIsProperty_F_C50_6_Removed();

        Boolean getIsProperty_F_C100_6_Removed();

        Boolean getIsProperty_F_C200_6_Removed();

        Boolean getIsProperty_F_C500_6_Removed();

        Boolean getIsProperty_F_B_7_Removed();

        Boolean getIsProperty_F_I_7_Removed();

        Boolean getIsProperty_F_L_7_Removed();

        Boolean getIsProperty_F_DT_7_Removed();

        Boolean getIsProperty_F_N_7_Removed();

        Boolean getIsProperty_F_C5_7_Removed();

        Boolean getIsProperty_F_C10_7_Removed();

        Boolean getIsProperty_F_C20_7_Removed();

        Boolean getIsProperty_F_C50_7_Removed();

        Boolean getIsProperty_F_C100_7_Removed();

        Boolean getIsProperty_F_C200_7_Removed();

        Boolean getIsProperty_F_C500_7_Removed();

        Boolean getIsProperty_F_B_8_Removed();

        Boolean getIsProperty_F_I_8_Removed();

        Boolean getIsProperty_F_L_8_Removed();

        Boolean getIsProperty_F_DT_8_Removed();

        Boolean getIsProperty_F_N_8_Removed();

        Boolean getIsProperty_F_C5_8_Removed();

        Boolean getIsProperty_F_C10_8_Removed();

        Boolean getIsProperty_F_C20_8_Removed();

        Boolean getIsProperty_F_C50_8_Removed();

        Boolean getIsProperty_F_C100_8_Removed();

        Boolean getIsProperty_F_C200_8_Removed();

        Boolean getIsProperty_F_C500_8_Removed();

        Boolean getIsProperty_F_B_9_Removed();

        Boolean getIsProperty_F_I_9_Removed();

        Boolean getIsProperty_F_L_9_Removed();

        Boolean getIsProperty_F_DT_9_Removed();

        Boolean getIsProperty_F_N_9_Removed();

        Boolean getIsProperty_F_C5_9_Removed();

        Boolean getIsProperty_F_C10_9_Removed();

        Boolean getIsProperty_F_C20_9_Removed();

        Boolean getIsProperty_F_C50_9_Removed();

        Boolean getIsProperty_F_C100_9_Removed();

        Boolean getIsProperty_F_C200_9_Removed();

        Boolean getIsProperty_F_C500_9_Removed();

        Boolean getIsProperty_F_B_10_Removed();

        Boolean getIsProperty_F_I_10_Removed();

        Boolean getIsProperty_F_L_10_Removed();

        Boolean getIsProperty_F_DT_10_Removed();

        Boolean getIsProperty_F_N_10_Removed();

        Boolean getIsProperty_F_C5_10_Removed();

        Boolean getIsProperty_F_C10_10_Removed();

        Boolean getIsProperty_F_C20_10_Removed();

        Boolean getIsProperty_F_C50_10_Removed();

        Boolean getIsProperty_F_C100_10_Removed();

        Boolean getIsProperty_F_C200_10_Removed();

        Boolean getIsProperty_F_B_11_Removed();

        Boolean getIsProperty_F_I_11_Removed();

        Boolean getIsProperty_F_L_11_Removed();

        Boolean getIsProperty_F_DT_11_Removed();

        Boolean getIsProperty_F_N_11_Removed();

        Boolean getIsProperty_F_C5_11_Removed();

        Boolean getIsProperty_F_C10_11_Removed();

        Boolean getIsProperty_F_C20_11_Removed();

        Boolean getIsProperty_F_C50_11_Removed();

        Boolean getIsProperty_F_C100_11_Removed();

        Boolean getIsProperty_F_C200_11_Removed();

        Boolean getIsProperty_F_B_12_Removed();

        Boolean getIsProperty_F_I_12_Removed();

        Boolean getIsProperty_F_L_12_Removed();

        Boolean getIsProperty_F_DT_12_Removed();

        Boolean getIsProperty_F_N_12_Removed();

        Boolean getIsProperty_F_C5_12_Removed();

        Boolean getIsProperty_F_C10_12_Removed();

        Boolean getIsProperty_F_C20_12_Removed();

        Boolean getIsProperty_F_C50_12_Removed();

        Boolean getIsProperty_F_C100_12_Removed();

        Boolean getIsProperty_F_C200_12_Removed();

        Boolean getIsProperty_F_B_13_Removed();

        Boolean getIsProperty_F_I_13_Removed();

        Boolean getIsProperty_F_L_13_Removed();

        Boolean getIsProperty_F_DT_13_Removed();

        Boolean getIsProperty_F_N_13_Removed();

        Boolean getIsProperty_F_C5_13_Removed();

        Boolean getIsProperty_F_C10_13_Removed();

        Boolean getIsProperty_F_C20_13_Removed();

        Boolean getIsProperty_F_C50_13_Removed();

        Boolean getIsProperty_F_C100_13_Removed();

        Boolean getIsProperty_F_C200_13_Removed();

        Boolean getIsProperty_F_B_14_Removed();

        Boolean getIsProperty_F_I_14_Removed();

        Boolean getIsProperty_F_L_14_Removed();

        Boolean getIsProperty_F_DT_14_Removed();

        Boolean getIsProperty_F_N_14_Removed();

        Boolean getIsProperty_F_C5_14_Removed();

        Boolean getIsProperty_F_C10_14_Removed();

        Boolean getIsProperty_F_C20_14_Removed();

        Boolean getIsProperty_F_C50_14_Removed();

        Boolean getIsProperty_F_C100_14_Removed();

        Boolean getIsProperty_F_C200_14_Removed();

        Boolean getIsProperty_F_B_15_Removed();

        Boolean getIsProperty_F_I_15_Removed();

        Boolean getIsProperty_F_L_15_Removed();

        Boolean getIsProperty_F_DT_15_Removed();

        Boolean getIsProperty_F_N_15_Removed();

        Boolean getIsProperty_F_C5_15_Removed();

        Boolean getIsProperty_F_C10_15_Removed();

        Boolean getIsProperty_F_C20_15_Removed();

        Boolean getIsProperty_F_C50_15_Removed();

        Boolean getIsProperty_F_C100_15_Removed();

        Boolean getIsProperty_F_C200_15_Removed();

        Boolean getIsProperty_F_B_16_Removed();

        Boolean getIsProperty_F_I_16_Removed();

        Boolean getIsProperty_F_L_16_Removed();

        Boolean getIsProperty_F_DT_16_Removed();

        Boolean getIsProperty_F_N_16_Removed();

        Boolean getIsProperty_F_C5_16_Removed();

        Boolean getIsProperty_F_C10_16_Removed();

        Boolean getIsProperty_F_C20_16_Removed();

        Boolean getIsProperty_F_C50_16_Removed();

        Boolean getIsProperty_F_C100_16_Removed();

        Boolean getIsProperty_F_C200_16_Removed();

        Boolean getIsProperty_F_B_17_Removed();

        Boolean getIsProperty_F_I_17_Removed();

        Boolean getIsProperty_F_L_17_Removed();

        Boolean getIsProperty_F_DT_17_Removed();

        Boolean getIsProperty_F_N_17_Removed();

        Boolean getIsProperty_F_C5_17_Removed();

        Boolean getIsProperty_F_C10_17_Removed();

        Boolean getIsProperty_F_C20_17_Removed();

        Boolean getIsProperty_F_C50_17_Removed();

        Boolean getIsProperty_F_C100_17_Removed();

        Boolean getIsProperty_F_C200_17_Removed();

        Boolean getIsProperty_F_B_18_Removed();

        Boolean getIsProperty_F_I_18_Removed();

        Boolean getIsProperty_F_L_18_Removed();

        Boolean getIsProperty_F_DT_18_Removed();

        Boolean getIsProperty_F_N_18_Removed();

        Boolean getIsProperty_F_C5_18_Removed();

        Boolean getIsProperty_F_C10_18_Removed();

        Boolean getIsProperty_F_C20_18_Removed();

        Boolean getIsProperty_F_C50_18_Removed();

        Boolean getIsProperty_F_C100_18_Removed();

        Boolean getIsProperty_F_C200_18_Removed();

        Boolean getIsProperty_F_B_19_Removed();

        Boolean getIsProperty_F_I_19_Removed();

        Boolean getIsProperty_F_L_19_Removed();

        Boolean getIsProperty_F_DT_19_Removed();

        Boolean getIsProperty_F_N_19_Removed();

        Boolean getIsProperty_F_C5_19_Removed();

        Boolean getIsProperty_F_C10_19_Removed();

        Boolean getIsProperty_F_C20_19_Removed();

        Boolean getIsProperty_F_C50_19_Removed();

        Boolean getIsProperty_F_C100_19_Removed();

        Boolean getIsProperty_F_C200_19_Removed();

        Boolean getIsProperty_F_B_20_Removed();

        Boolean getIsProperty_F_I_20_Removed();

        Boolean getIsProperty_F_L_20_Removed();

        Boolean getIsProperty_F_N_20_Removed();

        Boolean getIsProperty_F_C5_20_Removed();

        Boolean getIsProperty_F_C10_20_Removed();

        Boolean getIsProperty_F_C20_20_Removed();

        Boolean getIsProperty_F_C50_20_Removed();

        Boolean getIsProperty_F_B_21_Removed();

        Boolean getIsProperty_F_I_21_Removed();

        Boolean getIsProperty_F_L_21_Removed();

        Boolean getIsProperty_F_N_21_Removed();

        Boolean getIsProperty_F_C5_21_Removed();

        Boolean getIsProperty_F_C10_21_Removed();

        Boolean getIsProperty_F_C20_21_Removed();

        Boolean getIsProperty_F_C50_21_Removed();

        Boolean getIsProperty_F_B_22_Removed();

        Boolean getIsProperty_F_I_22_Removed();

        Boolean getIsProperty_F_L_22_Removed();

        Boolean getIsProperty_F_N_22_Removed();

        Boolean getIsProperty_F_C5_22_Removed();

        Boolean getIsProperty_F_C10_22_Removed();

        Boolean getIsProperty_F_C20_22_Removed();

        Boolean getIsProperty_F_C50_22_Removed();

        Boolean getIsProperty_F_B_23_Removed();

        Boolean getIsProperty_F_I_23_Removed();

        Boolean getIsProperty_F_L_23_Removed();

        Boolean getIsProperty_F_N_23_Removed();

        Boolean getIsProperty_F_C5_23_Removed();

        Boolean getIsProperty_F_C10_23_Removed();

        Boolean getIsProperty_F_C20_23_Removed();

        Boolean getIsProperty_F_C50_23_Removed();

        Boolean getIsProperty_F_B_24_Removed();

        Boolean getIsProperty_F_I_24_Removed();

        Boolean getIsProperty_F_L_24_Removed();

        Boolean getIsProperty_F_N_24_Removed();

        Boolean getIsProperty_F_C5_24_Removed();

        Boolean getIsProperty_F_C10_24_Removed();

        Boolean getIsProperty_F_C20_24_Removed();

        Boolean getIsProperty_F_C50_24_Removed();

        Boolean getIsProperty_F_B_25_Removed();

        Boolean getIsProperty_F_I_25_Removed();

        Boolean getIsProperty_F_L_25_Removed();

        Boolean getIsProperty_F_N_25_Removed();

        Boolean getIsProperty_F_C5_25_Removed();

        Boolean getIsProperty_F_C10_25_Removed();

        Boolean getIsProperty_F_C20_25_Removed();

        Boolean getIsProperty_F_C50_25_Removed();

        Boolean getIsProperty_F_B_26_Removed();

        Boolean getIsProperty_F_I_26_Removed();

        Boolean getIsProperty_F_L_26_Removed();

        Boolean getIsProperty_F_N_26_Removed();

        Boolean getIsProperty_F_C5_26_Removed();

        Boolean getIsProperty_F_C10_26_Removed();

        Boolean getIsProperty_F_C20_26_Removed();

        Boolean getIsProperty_F_C50_26_Removed();

        Boolean getIsProperty_F_B_27_Removed();

        Boolean getIsProperty_F_I_27_Removed();

        Boolean getIsProperty_F_L_27_Removed();

        Boolean getIsProperty_F_N_27_Removed();

        Boolean getIsProperty_F_C5_27_Removed();

        Boolean getIsProperty_F_C10_27_Removed();

        Boolean getIsProperty_F_C20_27_Removed();

        Boolean getIsProperty_F_C50_27_Removed();

        Boolean getIsProperty_F_B_28_Removed();

        Boolean getIsProperty_F_I_28_Removed();

        Boolean getIsProperty_F_L_28_Removed();

        Boolean getIsProperty_F_N_28_Removed();

        Boolean getIsProperty_F_C5_28_Removed();

        Boolean getIsProperty_F_C10_28_Removed();

        Boolean getIsProperty_F_C20_28_Removed();

        Boolean getIsProperty_F_C50_28_Removed();

        Boolean getIsProperty_F_B_29_Removed();

        Boolean getIsProperty_F_I_29_Removed();

        Boolean getIsProperty_F_L_29_Removed();

        Boolean getIsProperty_F_N_29_Removed();

        Boolean getIsProperty_F_C5_29_Removed();

        Boolean getIsProperty_F_C10_29_Removed();

        Boolean getIsProperty_F_C20_29_Removed();

        Boolean getIsProperty_F_C50_29_Removed();

        Boolean getIsProperty_F_B_30_Removed();

        Boolean getIsProperty_F_I_30_Removed();

        Boolean getIsProperty_F_N_30_Removed();

        Boolean getIsProperty_F_C5_30_Removed();

        Boolean getIsProperty_F_C10_30_Removed();

        Boolean getIsProperty_F_C20_30_Removed();

        Boolean getIsProperty_F_C50_30_Removed();

        Boolean getIsProperty_F_B_31_Removed();

        Boolean getIsProperty_F_I_31_Removed();

        Boolean getIsProperty_F_N_31_Removed();

        Boolean getIsProperty_F_C5_31_Removed();

        Boolean getIsProperty_F_C10_31_Removed();

        Boolean getIsProperty_F_C20_31_Removed();

        Boolean getIsProperty_F_C50_31_Removed();

        Boolean getIsProperty_F_B_32_Removed();

        Boolean getIsProperty_F_I_32_Removed();

        Boolean getIsProperty_F_N_32_Removed();

        Boolean getIsProperty_F_C5_32_Removed();

        Boolean getIsProperty_F_C10_32_Removed();

        Boolean getIsProperty_F_C20_32_Removed();

        Boolean getIsProperty_F_C50_32_Removed();

        Boolean getIsProperty_F_B_33_Removed();

        Boolean getIsProperty_F_I_33_Removed();

        Boolean getIsProperty_F_N_33_Removed();

        Boolean getIsProperty_F_C5_33_Removed();

        Boolean getIsProperty_F_C10_33_Removed();

        Boolean getIsProperty_F_C20_33_Removed();

        Boolean getIsProperty_F_C50_33_Removed();

        Boolean getIsProperty_F_B_34_Removed();

        Boolean getIsProperty_F_I_34_Removed();

        Boolean getIsProperty_F_N_34_Removed();

        Boolean getIsProperty_F_C5_34_Removed();

        Boolean getIsProperty_F_C10_34_Removed();

        Boolean getIsProperty_F_C20_34_Removed();

        Boolean getIsProperty_F_C50_34_Removed();

        Boolean getIsProperty_F_B_35_Removed();

        Boolean getIsProperty_F_I_35_Removed();

        Boolean getIsProperty_F_N_35_Removed();

        Boolean getIsProperty_F_C5_35_Removed();

        Boolean getIsProperty_F_C10_35_Removed();

        Boolean getIsProperty_F_C20_35_Removed();

        Boolean getIsProperty_F_C50_35_Removed();

        Boolean getIsProperty_F_B_36_Removed();

        Boolean getIsProperty_F_I_36_Removed();

        Boolean getIsProperty_F_N_36_Removed();

        Boolean getIsProperty_F_C5_36_Removed();

        Boolean getIsProperty_F_C10_36_Removed();

        Boolean getIsProperty_F_C20_36_Removed();

        Boolean getIsProperty_F_C50_36_Removed();

        Boolean getIsProperty_F_B_37_Removed();

        Boolean getIsProperty_F_I_37_Removed();

        Boolean getIsProperty_F_N_37_Removed();

        Boolean getIsProperty_F_C5_37_Removed();

        Boolean getIsProperty_F_C10_37_Removed();

        Boolean getIsProperty_F_C20_37_Removed();

        Boolean getIsProperty_F_C50_37_Removed();

        Boolean getIsProperty_F_B_38_Removed();

        Boolean getIsProperty_F_I_38_Removed();

        Boolean getIsProperty_F_N_38_Removed();

        Boolean getIsProperty_F_C5_38_Removed();

        Boolean getIsProperty_F_C10_38_Removed();

        Boolean getIsProperty_F_C20_38_Removed();

        Boolean getIsProperty_F_C50_38_Removed();

        Boolean getIsProperty_F_B_39_Removed();

        Boolean getIsProperty_F_I_39_Removed();

        Boolean getIsProperty_F_N_39_Removed();

        Boolean getIsProperty_F_C5_39_Removed();

        Boolean getIsProperty_F_C10_39_Removed();

        Boolean getIsProperty_F_C20_39_Removed();

        Boolean getIsProperty_F_C50_39_Removed();

        Boolean getIsProperty_F_B_40_Removed();

        Boolean getIsProperty_F_I_40_Removed();

        Boolean getIsProperty_F_N_40_Removed();

        Boolean getIsProperty_F_C5_40_Removed();

        Boolean getIsProperty_F_C10_40_Removed();

        Boolean getIsProperty_F_C20_40_Removed();

        Boolean getIsProperty_F_C50_40_Removed();

        Boolean getIsProperty_F_B_41_Removed();

        Boolean getIsProperty_F_I_41_Removed();

        Boolean getIsProperty_F_N_41_Removed();

        Boolean getIsProperty_F_C5_41_Removed();

        Boolean getIsProperty_F_C10_41_Removed();

        Boolean getIsProperty_F_C20_41_Removed();

        Boolean getIsProperty_F_C50_41_Removed();

        Boolean getIsProperty_F_B_42_Removed();

        Boolean getIsProperty_F_I_42_Removed();

        Boolean getIsProperty_F_N_42_Removed();

        Boolean getIsProperty_F_C5_42_Removed();

        Boolean getIsProperty_F_C10_42_Removed();

        Boolean getIsProperty_F_C20_42_Removed();

        Boolean getIsProperty_F_C50_42_Removed();

        Boolean getIsProperty_F_B_43_Removed();

        Boolean getIsProperty_F_I_43_Removed();

        Boolean getIsProperty_F_N_43_Removed();

        Boolean getIsProperty_F_C5_43_Removed();

        Boolean getIsProperty_F_C10_43_Removed();

        Boolean getIsProperty_F_C20_43_Removed();

        Boolean getIsProperty_F_C50_43_Removed();

        Boolean getIsProperty_F_B_44_Removed();

        Boolean getIsProperty_F_I_44_Removed();

        Boolean getIsProperty_F_N_44_Removed();

        Boolean getIsProperty_F_C5_44_Removed();

        Boolean getIsProperty_F_C10_44_Removed();

        Boolean getIsProperty_F_C20_44_Removed();

        Boolean getIsProperty_F_C50_44_Removed();

        Boolean getIsProperty_F_B_45_Removed();

        Boolean getIsProperty_F_I_45_Removed();

        Boolean getIsProperty_F_N_45_Removed();

        Boolean getIsProperty_F_C5_45_Removed();

        Boolean getIsProperty_F_C10_45_Removed();

        Boolean getIsProperty_F_C20_45_Removed();

        Boolean getIsProperty_F_C50_45_Removed();

        Boolean getIsProperty_F_B_46_Removed();

        Boolean getIsProperty_F_I_46_Removed();

        Boolean getIsProperty_F_N_46_Removed();

        Boolean getIsProperty_F_C5_46_Removed();

        Boolean getIsProperty_F_C10_46_Removed();

        Boolean getIsProperty_F_C20_46_Removed();

        Boolean getIsProperty_F_C50_46_Removed();

        Boolean getIsProperty_F_B_47_Removed();

        Boolean getIsProperty_F_I_47_Removed();

        Boolean getIsProperty_F_N_47_Removed();

        Boolean getIsProperty_F_C5_47_Removed();

        Boolean getIsProperty_F_C10_47_Removed();

        Boolean getIsProperty_F_C20_47_Removed();

        Boolean getIsProperty_F_C50_47_Removed();

        Boolean getIsProperty_F_B_48_Removed();

        Boolean getIsProperty_F_I_48_Removed();

        Boolean getIsProperty_F_N_48_Removed();

        Boolean getIsProperty_F_C5_48_Removed();

        Boolean getIsProperty_F_C10_48_Removed();

        Boolean getIsProperty_F_C20_48_Removed();

        Boolean getIsProperty_F_C50_48_Removed();

        Boolean getIsProperty_F_B_49_Removed();

        Boolean getIsProperty_F_I_49_Removed();

        Boolean getIsProperty_F_N_49_Removed();

        Boolean getIsProperty_F_C5_49_Removed();

        Boolean getIsProperty_F_C10_49_Removed();

        Boolean getIsProperty_F_C20_49_Removed();

        Boolean getIsProperty_F_C50_49_Removed();

        Boolean getIsPropertyActiveRemoved();

    }

	interface DeleteAttributeSetInstance extends AttributeSetInstanceCommand
	{
	}

}
