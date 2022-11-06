﻿using System;
using System.Xml.Serialization;
using M2dXmlGenerator;

namespace Maple2.File.Parser.Xml.Common;

[XmlType(Namespace = "Common")]
public class ItemOption {
    #region StatValue
    [XmlAttribute] public int str_value_base;
    [XmlAttribute] public int dex_value_base;
    [XmlAttribute] public int int_value_base;
    [XmlAttribute] public int luk_value_base;
    [XmlAttribute] public int hp_value_base;
    [XmlAttribute] public int hp_rgp_value_base;
    [XmlAttribute] public int hp_inv_value_base;
    [XmlAttribute] public int sp_value_base;
    [XmlAttribute] public int sp_rgp_value_base;
    [XmlAttribute] public int sp_inv_value_base;
    [XmlAttribute] public int ep_value_base;
    [XmlAttribute] public int ep_rgp_value_base;
    [XmlAttribute] public int ep_inv_value_base;
    [XmlAttribute] public int asp_value_base;
    [XmlAttribute] public int msp_value_base;
    [XmlAttribute] public int atp_value_base;
    [XmlAttribute] public int evp_value_base;
    [XmlAttribute] public int cap_value_base;
    [XmlAttribute] public int cad_value_base;
    [XmlAttribute] public int car_value_base;
    [XmlAttribute] public int ndd_value_base;
    [XmlAttribute] public int abp_value_base;
    [XmlAttribute] public int jmp_value_base;
    [XmlAttribute] public int pap_value_base;
    [XmlAttribute] public int map_value_base;
    [XmlAttribute] public int par_value_base;
    [XmlAttribute] public int mar_value_base;
    [XmlAttribute] public int wapmin_value_base;
    [XmlAttribute] public int wapmax_value_base;
    [XmlAttribute] public int dmg_value_base;
    [XmlAttribute] public int pen_value_base;
    [XmlAttribute] public int rmsp_value_base;
    [XmlAttribute] public int bap_value_base;
    [XmlAttribute] public int bap_pet_value_base;

    public int StatValue(byte i) => i switch {
        0 => str_value_base,
        1 => dex_value_base,
        2 => int_value_base,
        3 => luk_value_base,
        4 => hp_value_base,
        5 => hp_rgp_value_base,
        6 => hp_inv_value_base,
        7 => sp_value_base,
        8 => sp_rgp_value_base,
        9 => sp_inv_value_base,
        10 => ep_value_base,
        11 => ep_rgp_value_base,
        12 => ep_inv_value_base,
        13 => asp_value_base,
        14 => msp_value_base,
        15 => atp_value_base,
        16 => evp_value_base,
        17 => cap_value_base,
        18 => cad_value_base,
        19 => car_value_base,
        20 => ndd_value_base,
        21 => abp_value_base,
        22 => jmp_value_base,
        23 => pap_value_base,
        24 => map_value_base,
        25 => par_value_base,
        26 => mar_value_base,
        27 => wapmin_value_base,
        28 => wapmax_value_base,
        29 => dmg_value_base,
        30 => dmg_value_base,
        31 => pen_value_base,
        32 => rmsp_value_base,
        33 => bap_value_base,
        34 => bap_pet_value_base,
        _ => throw new ArgumentOutOfRangeException(nameof(i), i, null),
    };
    #endregion

    #region StatRate
    [XmlAttribute] public float str_rate_base;
    [XmlAttribute] public float dex_rate_base;
    [XmlAttribute] public float int_rate_base;
    [XmlAttribute] public float luk_rate_base;
    [XmlAttribute] public float hp_rate_base;
    [XmlAttribute] public float hp_rgp_rate_base;
    [XmlAttribute] public float hp_inv_rate_base;
    [XmlAttribute] public float sp_rate_base;
    [XmlAttribute] public float sp_rgp_rate_base;
    [XmlAttribute] public float sp_inv_rate_base;
    [XmlAttribute] public float ep_rate_base;
    [XmlAttribute] public float ep_rgp_rate_base;
    [XmlAttribute] public float ep_inv_rate_base;
    [XmlAttribute] public float asp_rate_base;
    [XmlAttribute] public float msp_rate_base;
    [XmlAttribute] public float atp_rate_base;
    [XmlAttribute] public float evp_rate_base;
    [XmlAttribute] public float cap_rate_base;
    [XmlAttribute] public float cad_rate_base;
    [XmlAttribute] public float car_rate_base;
    [XmlAttribute] public float ndd_rate_base;
    [XmlAttribute] public float abp_rate_base;
    [XmlAttribute] public float jmp_rate_base;
    [XmlAttribute] public float pap_rate_base;
    [XmlAttribute] public float map_rate_base;
    [XmlAttribute] public float par_rate_base;
    [XmlAttribute] public float mar_rate_base;
    [XmlAttribute] public float wapmin_rate_base;
    [XmlAttribute] public float wapmax_rate_base;
    [XmlAttribute] public float dmg_rate_base;
    [XmlAttribute] public float pen_rate_base;
    [XmlAttribute] public float rmsp_rate_base;
    [XmlAttribute] public float bap_rate_base;
    [XmlAttribute] public float bap_pet_rate_base;

    public float StatRate(byte i) => i switch {
        0 => str_rate_base,
        1 => dex_rate_base,
        2 => int_rate_base,
        3 => luk_rate_base,
        4 => hp_rate_base,
        5 => hp_rgp_rate_base,
        6 => hp_inv_rate_base,
        7 => sp_rate_base,
        8 => sp_rgp_rate_base,
        9 => sp_inv_rate_base,
        10 => ep_rate_base,
        11 => ep_rgp_rate_base,
        12 => ep_inv_rate_base,
        13 => asp_rate_base,
        14 => msp_rate_base,
        15 => atp_rate_base,
        16 => evp_rate_base,
        17 => cap_rate_base,
        18 => cad_rate_base,
        19 => car_rate_base,
        20 => ndd_rate_base,
        21 => abp_rate_base,
        22 => jmp_rate_base,
        23 => pap_rate_base,
        24 => map_rate_base,
        25 => par_rate_base,
        26 => mar_rate_base,
        27 => wapmin_rate_base,
        28 => wapmax_rate_base,
        29 => dmg_rate_base,
        30 => dmg_rate_base,
        31 => pen_rate_base,
        32 => rmsp_rate_base,
        33 => bap_rate_base,
        34 => bap_pet_rate_base,
        _ => throw new ArgumentOutOfRangeException(nameof(i), i, null),
    };
    #endregion

    #region SpecialValue
    [XmlAttribute] public int seg_value_base;
    [XmlAttribute] public int smd_value_base;
    [XmlAttribute] public int sss_value_base;
    [XmlAttribute] public int dashdistance_value_base;
    // [XmlAttribute] public int spd_value_base;
    // [XmlAttribute] public int sid_value_base;
    [XmlAttribute] public int finaladditionaldamage_value_base;
    [XmlAttribute] public int cri_value_base;
    [XmlAttribute] public int sgi_value_base;
    [XmlAttribute] public int sgi_leader_value_base;
    [XmlAttribute] public int sgi_elite_value_base;
    [XmlAttribute] public int sgi_boss_value_base;
    [XmlAttribute] public int killhprestore_value_base;
    [XmlAttribute] public int killsprestore_value_base;
    [XmlAttribute] public int killeprestore_value_base;
    [XmlAttribute] public int heal_value_base;
    [XmlAttribute] public int receivedhealincrease_value_base;
    [XmlAttribute] public int icedamage_value_base;
    [XmlAttribute] public int firedamage_value_base;
    [XmlAttribute] public int darkdamage_value_base;
    [XmlAttribute] public int lightdamage_value_base;
    [XmlAttribute] public int poisondamage_value_base;
    [XmlAttribute] public int thunderdamage_value_base;
    [XmlAttribute] public int nddincrease_value_base;
    [XmlAttribute] public int lddincrease_value_base;
    [XmlAttribute] public int parpen_value_base;
    [XmlAttribute] public int marpen_value_base;
    [XmlAttribute] public int icedamagereduce_value_base;
    [XmlAttribute] public int firedamagereduce_value_base;
    [XmlAttribute] public int darkdamagereduce_value_base;
    [XmlAttribute] public int lightdamagereduce_value_base;
    [XmlAttribute] public int poisondamagereduce_value_base;
    [XmlAttribute] public int thunderdamagereduce_value_base;
    [XmlAttribute] public int stunreduce_value_base;
    [XmlAttribute] public int conditionreduce_value_base;
    [XmlAttribute] public int skillcooldown_value_base;
    [XmlAttribute] public int neardistancedamagereduce_value_base;
    [XmlAttribute] public int longdistancedamagereduce_value_base;
    [XmlAttribute] public int knockbackreduce_value_base;
    [XmlAttribute] public int stunprocndd_value_base;
    [XmlAttribute] public int stunprocldd_value_base;
    [XmlAttribute] public int knockbackprocndd_value_base;
    [XmlAttribute] public int knockbackprocldd_value_base;
    [XmlAttribute] public int snareprocndd_value_base;
    [XmlAttribute] public int snareprocldd_value_base;
    [XmlAttribute] public int aoeprocndd_value_base;
    [XmlAttribute] public int aoeprocldd_value_base;
    [XmlAttribute] public int npckilldropitemincrate_value_base;
    [XmlAttribute] public int seg_questreward_value_base;
    [XmlAttribute] public int smd_questreward_value_base;
    [XmlAttribute] public int seg_fishingreward_value_base;
    [XmlAttribute] public int seg_arcadereward_value_base;
    [XmlAttribute] public int seg_playinstrumentreward_value_base;
    [XmlAttribute] public int invoke_effect1_value_base;
    [XmlAttribute] public int invoke_effect2_value_base;
    [XmlAttribute] public int invoke_effect3_value_base;
    [XmlAttribute] public int pvpdamageincrease_value_base;
    [XmlAttribute] public int pvpdamagereduce_value_base;
    [XmlAttribute] public int improveguildexp_value_base;
    [XmlAttribute] public int improveguildcoin_value_base;
    [XmlAttribute] public int improvemassiveeventbexpball_value_base;
    [XmlAttribute] public int reduce_meso_trade_fee_value_base;
    [XmlAttribute] public int reduce_enchant_matrial_fee_value_base;
    [XmlAttribute] public int reduce_merat_revival_fee_value_base;
    [XmlAttribute] public int improve_mining_reward_item_value_base;
    [XmlAttribute] public int improve_breeding_reward_item_value_base;
    [XmlAttribute] public int improve_blacksmithing_reward_mastery_value_base;
    [XmlAttribute] public int improve_engraving_reward_mastery_value_base;
    [XmlAttribute] public int improve_gathering_reward_item_value_base;
    [XmlAttribute] public int improve_farming_reward_item_value_base;
    [XmlAttribute] public int improve_alchemist_reward_mastery_value_base;
    [XmlAttribute] public int improve_cooking_reward_mastery_value_base;
    [XmlAttribute] public int improve_acquire_gathering_exp_value_base;
    [XmlAttribute] public int skill_levelup_tier_1_value_base;
    [XmlAttribute] public int skill_levelup_tier_2_value_base;
    [XmlAttribute] public int skill_levelup_tier_3_value_base;
    [XmlAttribute] public int skill_levelup_tier_4_value_base;
    [XmlAttribute] public int skill_levelup_tier_5_value_base;
    [XmlAttribute] public int skill_levelup_tier_6_value_base;
    [XmlAttribute] public int skill_levelup_tier_7_value_base;
    [XmlAttribute] public int skill_levelup_tier_8_value_base;
    [XmlAttribute] public int skill_levelup_tier_9_value_base;
    [XmlAttribute] public int skill_levelup_tier_10_value_base;
    [XmlAttribute] public int skill_levelup_tier_11_value_base;
    [XmlAttribute] public int skill_levelup_tier_12_value_base;
    [XmlAttribute] public int skill_levelup_tier_13_value_base;
    [XmlAttribute] public int skill_levelup_tier_14_value_base;
    [XmlAttribute] public int improve_massive_ox_exp_value_base;
    [XmlAttribute] public int improve_massive_trapmaster_exp_value_base;
    [XmlAttribute] public int improve_massive_finalsurvival_exp_value_base;
    [XmlAttribute] public int improve_massive_crazyrunner_exp_value_base;
    [XmlAttribute] public int improve_massive_sh_crazyrunner_exp_value_base;
    [XmlAttribute] public int improve_massive_escape_exp_value_base;
    [XmlAttribute] public int improve_massive_springbeach_exp_value_base;
    [XmlAttribute] public int improve_massive_dancedance_exp_value_base;
    [XmlAttribute] public int improve_massive_ox_msp_value_base;
    [XmlAttribute] public int improve_massive_trapmaster_msp_value_base;
    [XmlAttribute] public int improve_massive_finalsurvival_msp_value_base;
    [XmlAttribute] public int improve_massive_crazyrunner_msp_value_base;
    [XmlAttribute] public int improve_massive_sh_crazyrunner_msp_value_base;
    [XmlAttribute] public int improve_massive_escape_msp_value_base;
    [XmlAttribute] public int improve_massive_springbeach_msp_value_base;
    [XmlAttribute] public int improve_massive_dancedance_msp_value_base;
    [XmlAttribute] public int npc_hit_reward_sp_ball_value_base;
    [XmlAttribute] public int npc_hit_reward_ep_ball_value_base;
    [XmlAttribute] public int improve_honor_token_value_base;
    [XmlAttribute] public int improve_pvp_exp_value_base;
    [XmlAttribute] public int improve_darkstream_damage_value_base;
    [XmlAttribute] public int reduce_darkstream_recive_damage_value_base;
    [XmlAttribute] public int improve_darkstream_evp_value_base;
    [XmlAttribute] public int fishing_double_mastery_value_base;
    [XmlAttribute] public int playinstrument_double_mastery_value_base;
    [XmlAttribute] public int complete_fieldmission_msp_value_base;
    [XmlAttribute] public int improve_glide_vertical_velocity_value_base;
    [XmlAttribute] public int additionaleffect_95000018_value_base;
    [XmlAttribute] public int additionaleffect_95000012_value_base;
    [XmlAttribute] public int additionaleffect_95000014_value_base;
    [XmlAttribute] public int additionaleffect_95000020_value_base;
    [XmlAttribute] public int additionaleffect_95000021_value_base;
    [XmlAttribute] public int additionaleffect_95000022_value_base;
    [XmlAttribute] public int additionaleffect_95000023_value_base;
    [XmlAttribute] public int additionaleffect_95000024_value_base;
    [XmlAttribute] public int additionaleffect_95000025_value_base;
    [XmlAttribute] public int additionaleffect_95000026_value_base;
    [XmlAttribute] public int additionaleffect_95000027_value_base;
    [XmlAttribute] public int additionaleffect_95000028_value_base;
    [XmlAttribute] public int additionaleffect_95000029_value_base;
    [XmlAttribute] public int reduce_recovery_ep_inv_value_base;
    [XmlAttribute] public int improve_stat_wap_u_value_base;
    [XmlAttribute] public int mining_double_reward_value_base;
    [XmlAttribute] public int breeding_double_reward_value_base;
    [XmlAttribute] public int gathering_double_reward_value_base;
    [XmlAttribute] public int farming_double_reward_value_base;
    [XmlAttribute] public int blacksmithing_double_reward_value_base;
    [XmlAttribute] public int engraving_double_reward_value_base;
    [XmlAttribute] public int alchemist_double_reward_value_base;
    [XmlAttribute] public int cooking_double_reward_value_base;
    [XmlAttribute] public int mining_double_mastery_value_base;
    [XmlAttribute] public int breeding_double_mastery_value_base;
    [XmlAttribute] public int gathering_double_mastery_value_base;
    [XmlAttribute] public int farming_double_mastery_value_base;
    [XmlAttribute] public int blacksmithing_double_mastery_value_base;
    [XmlAttribute] public int engraving_double_mastery_value_base;
    [XmlAttribute] public int alchemist_double_mastery_value_base;
    [XmlAttribute] public int cooking_double_mastery_value_base;
    [XmlAttribute] public int improve_chaosraid_wap_value_base;
    [XmlAttribute] public int improve_chaosraid_asp_value_base;
    [XmlAttribute] public int improve_chaosraid_atp_value_base;
    [XmlAttribute] public int improve_chaosraid_hp_value_base;
    [XmlAttribute] public int improve_recovery_ball_value_base;
    [XmlAttribute] public int improve_fieldboss_kill_exp_value_base;
    [XmlAttribute] public int improve_fieldboss_kill_drop_value_base;
    [XmlAttribute] public int reduce_fieldboss_recive_damage_value_base;
    [XmlAttribute] public int additionaleffect_95000016_value_base;
    [XmlAttribute] public int improve_pettrap_reward_value_base;
    [XmlAttribute] public int mining_multiaction_value_base;
    [XmlAttribute] public int breeding_multiaction_value_base;
    [XmlAttribute] public int gathering_multiaction_value_base;
    [XmlAttribute] public int farming_multiaction_value_base;
    [XmlAttribute] public int reduce_damage_by_targetmaxhp_value_base;
    [XmlAttribute] public int reduce_meso_revival_fee_value_base;
    [XmlAttribute] public int improve_riding_run_speed_value_base;
    [XmlAttribute] public int improve_dungeon_reward_meso_value_base;
    [XmlAttribute] public int improve_shop_buying_meso_value_base;
    [XmlAttribute] public int improve_itembox_reward_meso_value_base;
    [XmlAttribute] public int reduce_remakeoption_fee_value_base;
    [XmlAttribute] public int reduce_airtaxi_fee_value_base;
    [XmlAttribute] public int improve_socket_unlock_probability_value_base;
    [XmlAttribute] public int reduce_gemstone_upgrade_fee_value_base;
    [XmlAttribute] public int reduce_pet_remakeoption_fee_value_base;
    [XmlAttribute] public int improve_riding_speed_value_base;
    // [XmlAttribute] public int improve_survival_kill_exp_value_base;
    // [XmlAttribute] public int improve_survival_time_exp_value_base;
    // [XmlAttribute] public int offensive_physicaldamage_value_base;
    // [XmlAttribute] public int offensive_magicaldamage_value_base;
    [XmlAttribute] public int reduce_gameitem_socket_unlock_fee_value_base;

    public int SpecialValue(byte i) => i switch {
        0 => seg_value_base,
        1 => smd_value_base,
        2 => sss_value_base,
        3 => dashdistance_value_base,
        // 4 => spd_value_base,
        // 5 => sid_value_base,
        6 => finaladditionaldamage_value_base,
        7 => cri_value_base,
        8 => sgi_value_base,
        9 => sgi_leader_value_base,
        10 => sgi_elite_value_base,
        11 => sgi_boss_value_base,
        12 => killhprestore_value_base,
        13 => killsprestore_value_base,
        14 => killeprestore_value_base,
        15 => heal_value_base,
        16 => receivedhealincrease_value_base,
        17 => icedamage_value_base,
        18 => firedamage_value_base,
        19 => darkdamage_value_base,
        20 => lightdamage_value_base,
        21 => poisondamage_value_base,
        22 => thunderdamage_value_base,
        23 => nddincrease_value_base,
        24 => lddincrease_value_base,
        25 => parpen_value_base,
        26 => marpen_value_base,
        27 => icedamagereduce_value_base,
        28 => firedamagereduce_value_base,
        29 => darkdamagereduce_value_base,
        30 => lightdamagereduce_value_base,
        31 => poisondamagereduce_value_base,
        32 => thunderdamagereduce_value_base,
        33 => stunreduce_value_base,
        34 => conditionreduce_value_base,
        35 => skillcooldown_value_base,
        36 => neardistancedamagereduce_value_base,
        37 => longdistancedamagereduce_value_base,
        38 => knockbackreduce_value_base,
        39 => stunprocndd_value_base,
        40 => stunprocldd_value_base,
        41 => knockbackprocndd_value_base,
        42 => knockbackprocldd_value_base,
        43 => snareprocndd_value_base,
        44 => snareprocldd_value_base,
        45 => aoeprocndd_value_base,
        46 => aoeprocldd_value_base,
        47 => npckilldropitemincrate_value_base,
        48 => seg_questreward_value_base,
        49 => smd_questreward_value_base,
        50 => seg_fishingreward_value_base,
        51 => seg_arcadereward_value_base,
        52 => seg_playinstrumentreward_value_base,
        53 => invoke_effect1_value_base,
        54 => invoke_effect2_value_base,
        55 => invoke_effect3_value_base,
        56 => pvpdamageincrease_value_base,
        57 => pvpdamagereduce_value_base,
        58 => improveguildexp_value_base,
        59 => improveguildcoin_value_base,
        60 => improvemassiveeventbexpball_value_base,
        61 => reduce_meso_trade_fee_value_base,
        62 => reduce_enchant_matrial_fee_value_base,
        63 => reduce_merat_revival_fee_value_base,
        64 => improve_mining_reward_item_value_base,
        65 => improve_breeding_reward_item_value_base,
        66 => improve_blacksmithing_reward_mastery_value_base,
        67 => improve_engraving_reward_mastery_value_base,
        68 => improve_gathering_reward_item_value_base,
        69 => improve_farming_reward_item_value_base,
        70 => improve_alchemist_reward_mastery_value_base,
        71 => improve_cooking_reward_mastery_value_base,
        72 => improve_acquire_gathering_exp_value_base,
        73 => skill_levelup_tier_1_value_base,
        74 => skill_levelup_tier_2_value_base,
        75 => skill_levelup_tier_3_value_base,
        76 => skill_levelup_tier_4_value_base,
        77 => skill_levelup_tier_5_value_base,
        78 => skill_levelup_tier_6_value_base,
        79 => skill_levelup_tier_7_value_base,
        80 => skill_levelup_tier_8_value_base,
        81 => skill_levelup_tier_9_value_base,
        82 => skill_levelup_tier_10_value_base,
        83 => skill_levelup_tier_11_value_base,
        84 => skill_levelup_tier_12_value_base,
        85 => skill_levelup_tier_13_value_base,
        86 => skill_levelup_tier_14_value_base,
        87 => improve_massive_ox_exp_value_base,
        88 => improve_massive_trapmaster_exp_value_base,
        89 => improve_massive_finalsurvival_exp_value_base,
        90 => improve_massive_crazyrunner_exp_value_base,
        91 => improve_massive_sh_crazyrunner_exp_value_base,
        92 => improve_massive_escape_exp_value_base,
        93 => improve_massive_springbeach_exp_value_base,
        94 => improve_massive_dancedance_exp_value_base,
        95 => improve_massive_ox_msp_value_base,
        96 => improve_massive_trapmaster_msp_value_base,
        97 => improve_massive_finalsurvival_msp_value_base,
        98 => improve_massive_crazyrunner_msp_value_base,
        99 => improve_massive_sh_crazyrunner_msp_value_base,
        100 => improve_massive_escape_msp_value_base,
        101 => improve_massive_springbeach_msp_value_base,
        102 => improve_massive_dancedance_msp_value_base,
        103 => npc_hit_reward_sp_ball_value_base,
        104 => npc_hit_reward_ep_ball_value_base,
        105 => improve_honor_token_value_base,
        106 => improve_pvp_exp_value_base,
        107 => improve_darkstream_damage_value_base,
        108 => reduce_darkstream_recive_damage_value_base,
        109 => improve_darkstream_evp_value_base,
        110 => fishing_double_mastery_value_base,
        111 => playinstrument_double_mastery_value_base,
        112 => complete_fieldmission_msp_value_base,
        113 => improve_glide_vertical_velocity_value_base,
        114 => additionaleffect_95000018_value_base,
        115 => additionaleffect_95000012_value_base,
        116 => additionaleffect_95000014_value_base,
        117 => additionaleffect_95000020_value_base,
        118 => additionaleffect_95000021_value_base,
        119 => additionaleffect_95000022_value_base,
        120 => additionaleffect_95000023_value_base,
        121 => additionaleffect_95000024_value_base,
        122 => additionaleffect_95000025_value_base,
        123 => additionaleffect_95000026_value_base,
        124 => additionaleffect_95000027_value_base,
        125 => additionaleffect_95000028_value_base,
        126 => additionaleffect_95000029_value_base,
        127 => reduce_recovery_ep_inv_value_base,
        128 => improve_stat_wap_u_value_base,
        129 => mining_double_reward_value_base,
        130 => breeding_double_reward_value_base,
        131 => gathering_double_reward_value_base,
        132 => farming_double_reward_value_base,
        133 => blacksmithing_double_reward_value_base,
        134 => engraving_double_reward_value_base,
        135 => alchemist_double_reward_value_base,
        136 => cooking_double_reward_value_base,
        137 => mining_double_mastery_value_base,
        138 => breeding_double_mastery_value_base,
        139 => gathering_double_mastery_value_base,
        140 => farming_double_mastery_value_base,
        141 => blacksmithing_double_mastery_value_base,
        142 => engraving_double_mastery_value_base,
        143 => alchemist_double_mastery_value_base,
        144 => cooking_double_mastery_value_base,
        145 => improve_chaosraid_wap_value_base,
        146 => improve_chaosraid_asp_value_base,
        147 => improve_chaosraid_atp_value_base,
        148 => improve_chaosraid_hp_value_base,
        149 => improve_recovery_ball_value_base,
        150 => improve_fieldboss_kill_exp_value_base,
        151 => improve_fieldboss_kill_drop_value_base,
        152 => reduce_fieldboss_recive_damage_value_base,
        153 => additionaleffect_95000016_value_base,
        154 => improve_pettrap_reward_value_base,
        155 => mining_multiaction_value_base,
        156 => breeding_multiaction_value_base,
        157 => gathering_multiaction_value_base,
        158 => farming_multiaction_value_base,
        159 => reduce_damage_by_targetmaxhp_value_base,
        160 => reduce_meso_revival_fee_value_base,
        161 => improve_riding_run_speed_value_base,
        162 => improve_dungeon_reward_meso_value_base,
        163 => improve_shop_buying_meso_value_base,
        164 => improve_itembox_reward_meso_value_base,
        165 => reduce_remakeoption_fee_value_base,
        166 => reduce_airtaxi_fee_value_base,
        167 => improve_socket_unlock_probability_value_base,
        168 => reduce_gemstone_upgrade_fee_value_base,
        169 => reduce_pet_remakeoption_fee_value_base,
        170 => improve_riding_speed_value_base,
        // 171 => improve_survival_kill_exp_value_base,
        // 172 => improve_survival_time_exp_value_base,
        // 173 => offensive_physicaldamage_value_base,
        // 174 => offensive_magicaldamage_value_base,
        175 => reduce_gameitem_socket_unlock_fee_value_base,
        _ => throw new ArgumentOutOfRangeException(nameof(i), i, null),
    };
    #endregion

    #region SpecialRate
    [XmlAttribute] public float seg_rate_base;
    [XmlAttribute] public float smd_rate_base;
    [XmlAttribute] public float sss_rate_base;
    [XmlAttribute] public float dashdistance_rate_base;
    // [XmlAttribute] public float spd_rate_base;
    // [XmlAttribute] public float sid_rate_base;
    [XmlAttribute] public float finaladditionaldamage_rate_base;
    [XmlAttribute] public float cri_rate_base;
    [XmlAttribute] public float sgi_rate_base;
    [XmlAttribute] public float sgi_leader_rate_base;
    [XmlAttribute] public float sgi_elite_rate_base;
    [XmlAttribute] public float sgi_boss_rate_base;
    [XmlAttribute] public float killhprestore_rate_base;
    [XmlAttribute] public float killsprestore_rate_base;
    [XmlAttribute] public float killeprestore_rate_base;
    [XmlAttribute] public float heal_rate_base;
    [XmlAttribute] public float receivedhealincrease_rate_base;
    [XmlAttribute] public float icedamage_rate_base;
    [XmlAttribute] public float firedamage_rate_base;
    [XmlAttribute] public float darkdamage_rate_base;
    [XmlAttribute] public float lightdamage_rate_base;
    [XmlAttribute] public float poisondamage_rate_base;
    [XmlAttribute] public float thunderdamage_rate_base;
    [XmlAttribute] public float nddincrease_rate_base;
    [XmlAttribute] public float lddincrease_rate_base;
    [XmlAttribute] public float parpen_rate_base;
    [XmlAttribute] public float marpen_rate_base;
    [XmlAttribute] public float icedamagereduce_rate_base;
    [XmlAttribute] public float firedamagereduce_rate_base;
    [XmlAttribute] public float darkdamagereduce_rate_base;
    [XmlAttribute] public float lightdamagereduce_rate_base;
    [XmlAttribute] public float poisondamagereduce_rate_base;
    [XmlAttribute] public float thunderdamagereduce_rate_base;
    [XmlAttribute] public float stunreduce_rate_base;
    [XmlAttribute] public float conditionreduce_rate_base;
    [XmlAttribute] public float skillcooldown_rate_base;
    [XmlAttribute] public float neardistancedamagereduce_rate_base;
    [XmlAttribute] public float longdistancedamagereduce_rate_base;
    [XmlAttribute] public float knockbackreduce_rate_base;
    [XmlAttribute] public float stunprocndd_rate_base;
    [XmlAttribute] public float stunprocldd_rate_base;
    [XmlAttribute] public float knockbackprocndd_rate_base;
    [XmlAttribute] public float knockbackprocldd_rate_base;
    [XmlAttribute] public float snareprocndd_rate_base;
    [XmlAttribute] public float snareprocldd_rate_base;
    [XmlAttribute] public float aoeprocndd_rate_base;
    [XmlAttribute] public float aoeprocldd_rate_base;
    [XmlAttribute] public float npckilldropitemincrate_rate_base;
    [XmlAttribute] public float seg_questreward_rate_base;
    [XmlAttribute] public float smd_questreward_rate_base;
    [XmlAttribute] public float seg_fishingreward_rate_base;
    [XmlAttribute] public float seg_arcadereward_rate_base;
    [XmlAttribute] public float seg_playinstrumentreward_rate_base;
    [XmlAttribute] public float invoke_effect1_rate_base;
    [XmlAttribute] public float invoke_effect2_rate_base;
    [XmlAttribute] public float invoke_effect3_rate_base;
    [XmlAttribute] public float pvpdamageincrease_rate_base;
    [XmlAttribute] public float pvpdamagereduce_rate_base;
    [XmlAttribute] public float improveguildexp_rate_base;
    [XmlAttribute] public float improveguildcoin_rate_base;
    [XmlAttribute] public float improvemassiveeventbexpball_rate_base;
    [XmlAttribute] public float reduce_meso_trade_fee_rate_base;
    [XmlAttribute] public float reduce_enchant_matrial_fee_rate_base;
    [XmlAttribute] public float reduce_merat_revival_fee_rate_base;
    [XmlAttribute] public float improve_mining_reward_item_rate_base;
    [XmlAttribute] public float improve_breeding_reward_item_rate_base;
    [XmlAttribute] public float improve_blacksmithing_reward_mastery_rate_base;
    [XmlAttribute] public float improve_engraving_reward_mastery_rate_base;
    [XmlAttribute] public float improve_gathering_reward_item_rate_base;
    [XmlAttribute] public float improve_farming_reward_item_rate_base;
    [XmlAttribute] public float improve_alchemist_reward_mastery_rate_base;
    [XmlAttribute] public float improve_cooking_reward_mastery_rate_base;
    [XmlAttribute] public float improve_acquire_gathering_exp_rate_base;
    [XmlAttribute] public float skill_levelup_tier_1_rate_base;
    [XmlAttribute] public float skill_levelup_tier_2_rate_base;
    [XmlAttribute] public float skill_levelup_tier_3_rate_base;
    [XmlAttribute] public float skill_levelup_tier_4_rate_base;
    [XmlAttribute] public float skill_levelup_tier_5_rate_base;
    [XmlAttribute] public float skill_levelup_tier_6_rate_base;
    [XmlAttribute] public float skill_levelup_tier_7_rate_base;
    [XmlAttribute] public float skill_levelup_tier_8_rate_base;
    [XmlAttribute] public float skill_levelup_tier_9_rate_base;
    [XmlAttribute] public float skill_levelup_tier_10_rate_base;
    [XmlAttribute] public float skill_levelup_tier_11_rate_base;
    [XmlAttribute] public float skill_levelup_tier_12_rate_base;
    [XmlAttribute] public float skill_levelup_tier_13_rate_base;
    [XmlAttribute] public float skill_levelup_tier_14_rate_base;
    [XmlAttribute] public float improve_massive_ox_exp_rate_base;
    [XmlAttribute] public float improve_massive_trapmaster_exp_rate_base;
    [XmlAttribute] public float improve_massive_finalsurvival_exp_rate_base;
    [XmlAttribute] public float improve_massive_crazyrunner_exp_rate_base;
    [XmlAttribute] public float improve_massive_sh_crazyrunner_exp_rate_base;
    [XmlAttribute] public float improve_massive_escape_exp_rate_base;
    [XmlAttribute] public float improve_massive_springbeach_exp_rate_base;
    [XmlAttribute] public float improve_massive_dancedance_exp_rate_base;
    [XmlAttribute] public float improve_massive_ox_msp_rate_base;
    [XmlAttribute] public float improve_massive_trapmaster_msp_rate_base;
    [XmlAttribute] public float improve_massive_finalsurvival_msp_rate_base;
    [XmlAttribute] public float improve_massive_crazyrunner_msp_rate_base;
    [XmlAttribute] public float improve_massive_sh_crazyrunner_msp_rate_base;
    [XmlAttribute] public float improve_massive_escape_msp_rate_base;
    [XmlAttribute] public float improve_massive_springbeach_msp_rate_base;
    [XmlAttribute] public float improve_massive_dancedance_msp_rate_base;
    [XmlAttribute] public float npc_hit_reward_sp_ball_rate_base;
    [XmlAttribute] public float npc_hit_reward_ep_ball_rate_base;
    [XmlAttribute] public float improve_honor_token_rate_base;
    [XmlAttribute] public float improve_pvp_exp_rate_base;
    [XmlAttribute] public float improve_darkstream_damage_rate_base;
    [XmlAttribute] public float reduce_darkstream_recive_damage_rate_base;
    [XmlAttribute] public float improve_darkstream_evp_rate_base;
    [XmlAttribute] public float fishing_double_mastery_rate_base;
    [XmlAttribute] public float playinstrument_double_mastery_rate_base;
    [XmlAttribute] public float complete_fieldmission_msp_rate_base;
    [XmlAttribute] public float improve_glide_vertical_velocity_rate_base;
    [XmlAttribute] public float additionaleffect_95000018_rate_base;
    [XmlAttribute] public float additionaleffect_95000012_rate_base;
    [XmlAttribute] public float additionaleffect_95000014_rate_base;
    [XmlAttribute] public float additionaleffect_95000020_rate_base;
    [XmlAttribute] public float additionaleffect_95000021_rate_base;
    [XmlAttribute] public float additionaleffect_95000022_rate_base;
    [XmlAttribute] public float additionaleffect_95000023_rate_base;
    [XmlAttribute] public float additionaleffect_95000024_rate_base;
    [XmlAttribute] public float additionaleffect_95000025_rate_base;
    [XmlAttribute] public float additionaleffect_95000026_rate_base;
    [XmlAttribute] public float additionaleffect_95000027_rate_base;
    [XmlAttribute] public float additionaleffect_95000028_rate_base;
    [XmlAttribute] public float additionaleffect_95000029_rate_base;
    [XmlAttribute] public float reduce_recovery_ep_inv_rate_base;
    [XmlAttribute] public float improve_stat_wap_u_rate_base;
    [XmlAttribute] public float mining_double_reward_rate_base;
    [XmlAttribute] public float breeding_double_reward_rate_base;
    [XmlAttribute] public float gathering_double_reward_rate_base;
    [XmlAttribute] public float farming_double_reward_rate_base;
    [XmlAttribute] public float blacksmithing_double_reward_rate_base;
    [XmlAttribute] public float engraving_double_reward_rate_base;
    [XmlAttribute] public float alchemist_double_reward_rate_base;
    [XmlAttribute] public float cooking_double_reward_rate_base;
    [XmlAttribute] public float mining_double_mastery_rate_base;
    [XmlAttribute] public float breeding_double_mastery_rate_base;
    [XmlAttribute] public float gathering_double_mastery_rate_base;
    [XmlAttribute] public float farming_double_mastery_rate_base;
    [XmlAttribute] public float blacksmithing_double_mastery_rate_base;
    [XmlAttribute] public float engraving_double_mastery_rate_base;
    [XmlAttribute] public float alchemist_double_mastery_rate_base;
    [XmlAttribute] public float cooking_double_mastery_rate_base;
    [XmlAttribute] public float improve_chaosraid_wap_rate_base;
    [XmlAttribute] public float improve_chaosraid_asp_rate_base;
    [XmlAttribute] public float improve_chaosraid_atp_rate_base;
    [XmlAttribute] public float improve_chaosraid_hp_rate_base;
    [XmlAttribute] public float improve_recovery_ball_rate_base;
    [XmlAttribute] public float improve_fieldboss_kill_exp_rate_base;
    [XmlAttribute] public float improve_fieldboss_kill_drop_rate_base;
    [XmlAttribute] public float reduce_fieldboss_recive_damage_rate_base;
    [XmlAttribute] public float additionaleffect_95000016_rate_base;
    [XmlAttribute] public float improve_pettrap_reward_rate_base;
    [XmlAttribute] public float mining_multiaction_rate_base;
    [XmlAttribute] public float breeding_multiaction_rate_base;
    [XmlAttribute] public float gathering_multiaction_rate_base;
    [XmlAttribute] public float farming_multiaction_rate_base;
    [XmlAttribute] public float reduce_damage_by_targetmaxhp_rate_base;
    [XmlAttribute] public float reduce_meso_revival_fee_rate_base;
    [XmlAttribute] public float improve_riding_run_speed_rate_base;
    [XmlAttribute] public float improve_dungeon_reward_meso_rate_base;
    [XmlAttribute] public float improve_shop_buying_meso_rate_base;
    [XmlAttribute] public float improve_itembox_reward_meso_rate_base;
    [XmlAttribute] public float reduce_remakeoption_fee_rate_base;
    [XmlAttribute] public float reduce_airtaxi_fee_rate_base;
    [XmlAttribute] public float improve_socket_unlock_probability_rate_base;
    [XmlAttribute] public float reduce_gemstone_upgrade_fee_rate_base;
    [XmlAttribute] public float reduce_pet_remakeoption_fee_rate_base;
    [XmlAttribute] public float improve_riding_speed_rate_base;
    // [XmlAttribute] public float improve_survival_kill_exp_rate_base;
    // [XmlAttribute] public float improve_survival_time_exp_rate_base;
    // [XmlAttribute] public float offensive_physicaldamage_rate_base;
    // [XmlAttribute] public float offensive_magicaldamage_rate_base;
    [XmlAttribute] public float reduce_gameitem_socket_unlock_fee_rate_base;

    public float SpecialRate(byte i) => i switch {
        0 => seg_rate_base,
        1 => smd_rate_base,
        2 => sss_rate_base,
        3 => dashdistance_rate_base,
        // 4 => spd_rate_base,
        // 5 => sid_rate_base,
        6 => finaladditionaldamage_rate_base,
        7 => cri_rate_base,
        8 => sgi_rate_base,
        9 => sgi_leader_rate_base,
        10 => sgi_elite_rate_base,
        11 => sgi_boss_rate_base,
        12 => killhprestore_rate_base,
        13 => killsprestore_rate_base,
        14 => killeprestore_rate_base,
        15 => heal_rate_base,
        16 => receivedhealincrease_rate_base,
        17 => icedamage_rate_base,
        18 => firedamage_rate_base,
        19 => darkdamage_rate_base,
        20 => lightdamage_rate_base,
        21 => poisondamage_rate_base,
        22 => thunderdamage_rate_base,
        23 => nddincrease_rate_base,
        24 => lddincrease_rate_base,
        25 => parpen_rate_base,
        26 => marpen_rate_base,
        27 => icedamagereduce_rate_base,
        28 => firedamagereduce_rate_base,
        29 => darkdamagereduce_rate_base,
        30 => lightdamagereduce_rate_base,
        31 => poisondamagereduce_rate_base,
        32 => thunderdamagereduce_rate_base,
        33 => stunreduce_rate_base,
        34 => conditionreduce_rate_base,
        35 => skillcooldown_rate_base,
        36 => neardistancedamagereduce_rate_base,
        37 => longdistancedamagereduce_rate_base,
        38 => knockbackreduce_rate_base,
        39 => stunprocndd_rate_base,
        40 => stunprocldd_rate_base,
        41 => knockbackprocndd_rate_base,
        42 => knockbackprocldd_rate_base,
        43 => snareprocndd_rate_base,
        44 => snareprocldd_rate_base,
        45 => aoeprocndd_rate_base,
        46 => aoeprocldd_rate_base,
        47 => npckilldropitemincrate_rate_base,
        48 => seg_questreward_rate_base,
        49 => smd_questreward_rate_base,
        50 => seg_fishingreward_rate_base,
        51 => seg_arcadereward_rate_base,
        52 => seg_playinstrumentreward_rate_base,
        53 => invoke_effect1_rate_base,
        54 => invoke_effect2_rate_base,
        55 => invoke_effect3_rate_base,
        56 => pvpdamageincrease_rate_base,
        57 => pvpdamagereduce_rate_base,
        58 => improveguildexp_rate_base,
        59 => improveguildcoin_rate_base,
        60 => improvemassiveeventbexpball_rate_base,
        61 => reduce_meso_trade_fee_rate_base,
        62 => reduce_enchant_matrial_fee_rate_base,
        63 => reduce_merat_revival_fee_rate_base,
        64 => improve_mining_reward_item_rate_base,
        65 => improve_breeding_reward_item_rate_base,
        66 => improve_blacksmithing_reward_mastery_rate_base,
        67 => improve_engraving_reward_mastery_rate_base,
        68 => improve_gathering_reward_item_rate_base,
        69 => improve_farming_reward_item_rate_base,
        70 => improve_alchemist_reward_mastery_rate_base,
        71 => improve_cooking_reward_mastery_rate_base,
        72 => improve_acquire_gathering_exp_rate_base,
        73 => skill_levelup_tier_1_rate_base,
        74 => skill_levelup_tier_2_rate_base,
        75 => skill_levelup_tier_3_rate_base,
        76 => skill_levelup_tier_4_rate_base,
        77 => skill_levelup_tier_5_rate_base,
        78 => skill_levelup_tier_6_rate_base,
        79 => skill_levelup_tier_7_rate_base,
        80 => skill_levelup_tier_8_rate_base,
        81 => skill_levelup_tier_9_rate_base,
        82 => skill_levelup_tier_10_rate_base,
        83 => skill_levelup_tier_11_rate_base,
        84 => skill_levelup_tier_12_rate_base,
        85 => skill_levelup_tier_13_rate_base,
        86 => skill_levelup_tier_14_rate_base,
        87 => improve_massive_ox_exp_rate_base,
        88 => improve_massive_trapmaster_exp_rate_base,
        89 => improve_massive_finalsurvival_exp_rate_base,
        90 => improve_massive_crazyrunner_exp_rate_base,
        91 => improve_massive_sh_crazyrunner_exp_rate_base,
        92 => improve_massive_escape_exp_rate_base,
        93 => improve_massive_springbeach_exp_rate_base,
        94 => improve_massive_dancedance_exp_rate_base,
        95 => improve_massive_ox_msp_rate_base,
        96 => improve_massive_trapmaster_msp_rate_base,
        97 => improve_massive_finalsurvival_msp_rate_base,
        98 => improve_massive_crazyrunner_msp_rate_base,
        99 => improve_massive_sh_crazyrunner_msp_rate_base,
        100 => improve_massive_escape_msp_rate_base,
        101 => improve_massive_springbeach_msp_rate_base,
        102 => improve_massive_dancedance_msp_rate_base,
        103 => npc_hit_reward_sp_ball_rate_base,
        104 => npc_hit_reward_ep_ball_rate_base,
        105 => improve_honor_token_rate_base,
        106 => improve_pvp_exp_rate_base,
        107 => improve_darkstream_damage_rate_base,
        108 => reduce_darkstream_recive_damage_rate_base,
        109 => improve_darkstream_evp_rate_base,
        110 => fishing_double_mastery_rate_base,
        111 => playinstrument_double_mastery_rate_base,
        112 => complete_fieldmission_msp_rate_base,
        113 => improve_glide_vertical_velocity_rate_base,
        114 => additionaleffect_95000018_rate_base,
        115 => additionaleffect_95000012_rate_base,
        116 => additionaleffect_95000014_rate_base,
        117 => additionaleffect_95000020_rate_base,
        118 => additionaleffect_95000021_rate_base,
        119 => additionaleffect_95000022_rate_base,
        120 => additionaleffect_95000023_rate_base,
        121 => additionaleffect_95000024_rate_base,
        122 => additionaleffect_95000025_rate_base,
        123 => additionaleffect_95000026_rate_base,
        124 => additionaleffect_95000027_rate_base,
        125 => additionaleffect_95000028_rate_base,
        126 => additionaleffect_95000029_rate_base,
        127 => reduce_recovery_ep_inv_rate_base,
        128 => improve_stat_wap_u_rate_base,
        129 => mining_double_reward_rate_base,
        130 => breeding_double_reward_rate_base,
        131 => gathering_double_reward_rate_base,
        132 => farming_double_reward_rate_base,
        133 => blacksmithing_double_reward_rate_base,
        134 => engraving_double_reward_rate_base,
        135 => alchemist_double_reward_rate_base,
        136 => cooking_double_reward_rate_base,
        137 => mining_double_mastery_rate_base,
        138 => breeding_double_mastery_rate_base,
        139 => gathering_double_mastery_rate_base,
        140 => farming_double_mastery_rate_base,
        141 => blacksmithing_double_mastery_rate_base,
        142 => engraving_double_mastery_rate_base,
        143 => alchemist_double_mastery_rate_base,
        144 => cooking_double_mastery_rate_base,
        145 => improve_chaosraid_wap_rate_base,
        146 => improve_chaosraid_asp_rate_base,
        147 => improve_chaosraid_atp_rate_base,
        148 => improve_chaosraid_hp_rate_base,
        149 => improve_recovery_ball_rate_base,
        150 => improve_fieldboss_kill_exp_rate_base,
        151 => improve_fieldboss_kill_drop_rate_base,
        152 => reduce_fieldboss_recive_damage_rate_base,
        153 => additionaleffect_95000016_rate_base,
        154 => improve_pettrap_reward_rate_base,
        155 => mining_multiaction_rate_base,
        156 => breeding_multiaction_rate_base,
        157 => gathering_multiaction_rate_base,
        158 => farming_multiaction_rate_base,
        159 => reduce_damage_by_targetmaxhp_rate_base,
        160 => reduce_meso_revival_fee_rate_base,
        161 => improve_riding_run_speed_rate_base,
        162 => improve_dungeon_reward_meso_rate_base,
        163 => improve_shop_buying_meso_rate_base,
        164 => improve_itembox_reward_meso_rate_base,
        165 => reduce_remakeoption_fee_rate_base,
        166 => reduce_airtaxi_fee_rate_base,
        167 => improve_socket_unlock_probability_rate_base,
        168 => reduce_gemstone_upgrade_fee_rate_base,
        169 => reduce_pet_remakeoption_fee_rate_base,
        170 => improve_riding_speed_rate_base,
        // 171 => improve_survival_kill_exp_rate_base,
        // 172 => improve_survival_time_exp_rate_base,
        // 173 => offensive_physicaldamage_rate_base,
        // 174 => offensive_magicaldamage_rate_base,
        175 => reduce_gameitem_socket_unlock_fee_rate_base,
        _ => throw new ArgumentOutOfRangeException(nameof(i), i, null),
    };
    #endregion
}
