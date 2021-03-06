﻿using ElectronicObserver.Utility.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Data
{

	public static class Constants
	{

		#region 艦船・装備

		/// <summary>
		/// 艦船の速力を表す文字列を取得します。
		/// </summary>
		public static string GetSpeed(int value)
		{
			switch (value)
			{
				case 0:
					return "陸上";
				case 5:
					return "低速";
				case 10:
					return "高速";
				case 15:
					return "高速+";
				case 20:
					return "最速";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 射程を表す文字列を取得します。
		/// </summary>
		public static string GetRange(int value)
		{
			switch (value)
			{
				case 0:
					return "無";
				case 1:
					return "短";
				case 2:
					return "中";
				case 3:
					return "長";
				case 4:
					return "超長";
				case 5:
					return "超長+";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 艦船のレアリティを表す文字列を取得します。
		/// </summary>
		public static string GetShipRarity(int value)
		{
			switch (value)
			{
				case 0:
					return "赤";
				case 1:
					return "藍";
				case 2:
					return "青";
				case 3:
					return "水";
				case 4:
					return "銀";
				case 5:
					return "金";
				case 6:
					return "虹";
				case 7:
					return "輝虹";
				case 8:
					return "桜虹";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 装備のレアリティを表す文字列を取得します。
		/// </summary>
		public static string GetEquipmentRarity(int value)
		{
			switch (value)
			{
				case 0:
					return "コモン";
				case 1:
					return "レア";
				case 2:
					return "ホロ";
				case 3:
					return "Sホロ";
				case 4:
					return "SSホロ";
				case 5:
					return "SSホロ'";
				case 6:
					return "SSホロ+";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 装備のレアリティの画像インデックスを取得します。
		/// </summary>
		public static int GetEquipmentRarityID(int value)
		{
			switch (value)
			{
				case 0:
					return 1;
				case 1:
					return 3;
				case 2:
					return 4;
				case 3:
					return 5;
				case 4:
					return 6;
				case 5:
					return 7;
				case 6:
					return 8;
				default:
					return 0;
			}
		}


		/// <summary>
		/// 艦船のボイス設定フラグを表す文字列を取得します。
		/// </summary>
		public static string GetVoiceFlag(int value)
		{

			switch (value)
			{
				case 0:
					return "-";
				case 1:
					return "時報";
				case 2:
					return "放置";
				case 3:
					return "時報+放置";
				case 4:
					return "特殊放置";
				case 5:
					return "時報+特殊放置";
				case 6:
					return "放置+特殊放置";
				case 7:
					return "時報+放置+特殊放置";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 艦船の損傷度合いを表す文字列を取得します。
		/// </summary>
		/// <param name="hprate">現在HP/最大HPで表される割合。</param>
		/// <param name="isPractice">演習かどうか。</param>
		/// <param name="isLandBase">陸上基地かどうか。</param>
		/// <param name="isEscaped">退避中かどうか。</param>
		/// <returns></returns>
		public static string GetDamageState(double hprate, bool isPractice = false, bool isLandBase = false, bool isEscaped = false)
		{

			if (isEscaped)
				return "退避";
			else if (hprate <= 0.0)
				return isPractice ? "離脱" : (!isLandBase ? "撃沈" : "破壊");
			else if (hprate <= 0.25)
				return !isLandBase ? "大破" : "損壊";
			else if (hprate <= 0.5)
				return !isLandBase ? "中破" : "損害";
			else if (hprate <= 0.75)
				return !isLandBase ? "小破" : "混乱";
			else if (hprate < 1.0)
				return "健在";
			else
				return "無傷";

		}


		/// <summary>
		/// 基地航空隊の行動指示を表す文字列を取得します。
		/// </summary>
		public static string GetBaseAirCorpsActionKind(int value)
		{
			switch (value)
			{
				case 0:
					return "待機";
				case 1:
					return "出撃";
				case 2:
					return "防空";
				case 3:
					return "退避";
				case 4:
					return "休息";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 艦種略号を取得します。
		/// </summary>
		public static string GetShipClassClassification(ShipTypes shiptype)
		{
			switch (shiptype)
			{
				case ShipTypes.Escort:
					return "DE";
				case ShipTypes.Destroyer:
					return "DD";
				case ShipTypes.LightCruiser:
					return "CL";
				case ShipTypes.TorpedoCruiser:
					return "CLT";
				case ShipTypes.HeavyCruiser:
					return "CA";
				case ShipTypes.AviationCruiser:
					return "CAV";
				case ShipTypes.LightAircraftCarrier:
					return "CVL";
				case ShipTypes.Battlecruiser:
					return "BC";    // ? FBB, CC?
				case ShipTypes.Battleship:
					return "BB";
				case ShipTypes.AviationBattleship:
					return "BBV";
				case ShipTypes.AircraftCarrier:
					return "CV";
				case ShipTypes.SuperDreadnoughts:
					return "BB";
				case ShipTypes.Submarine:
					return "SS";
				case ShipTypes.SubmarineAircraftCarrier:
					return "SSV";
				case ShipTypes.Transport:
					return "AP";    // ? AO?
				case ShipTypes.SeaplaneTender:
					return "AV";
				case ShipTypes.AmphibiousAssaultShip:
					return "LHA";
				case ShipTypes.ArmoredAircraftCarrier:
					return "CVB";
				case ShipTypes.RepairShip:
					return "AR";
				case ShipTypes.SubmarineTender:
					return "AS";
				case ShipTypes.TrainingCruiser:
					return "CT";
				case ShipTypes.FleetOiler:
					return "AO";
				default:
					return "IX";
			}
		}

		#endregion


		#region 出撃

		/// <summary>
		/// マップ上のセルでのイベントを表す文字列を取得します。
		/// </summary>
		public static string GetMapEventID(int value)
		{

			switch (value)
			{

				case 0:
					return "初期位置";
				case 1:
					return "なし";
				case 2:
					return "資源";
				case 3:
					return "渦潮";
				case 4:
					return "通常戦闘";
				case 5:
					return "ボス戦闘";
				case 6:
					return "気のせいだった";
				case 7:
					return "航空戦";
				case 8:
					return "船団護衛成功";
				case 9:
					return "揚陸地点";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// マップ上のセルでのイベント種別を表す文字列を取得します。
		/// </summary>
		public static string GetMapEventKind(int value)
		{

			switch (value)
			{
				case 0:
					return "非戦闘";
				case 1:
					return "昼夜戦";
				case 2:
					return "夜戦";
				case 3:
					return "夜昼戦";		// 対通常?
				case 4:
					return "航空戦";
				case 5:
					return "敵連合";
				case 6:
					return "空襲戦";
				case 7:
					return "夜昼戦";		// 対連合
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 海域難易度を表す文字列を取得します。
		/// </summary>
		public static string GetDifficulty(int value)
		{

			switch (value)
			{
				case -1:
					return "なし";
				case 0:
					return "未選択";
				case 1:
					return "丙";
				case 2:
					return "乙";
				case 3:
					return "甲";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 海域難易度を表す数値を取得します。
		/// </summary>
		public static int GetDifficulty(string value)
		{

			switch (value)
			{
				case "未選択":
					return 0;
				case "丙":
					return 1;
				case "乙":
					return 2;
				case "甲":
					return 3;
				default:
					return -1;
			}

		}

		/// <summary>
		/// 空襲被害の状態を表す文字列を取得します。
		/// </summary>
		public static string GetAirRaidDamage(int value)
		{
			switch (value)
			{
				case 1:
					return "空襲発生 - 資源に損害";
				case 2:
					return "空襲発生 - 資源・航空隊に損害";
				case 3:
					return "空襲発生 - 航空隊に損害";
				case 4:
					return "空襲発生 - 損害なし";
				default:
					return "空襲発生せず";
			}
		}

		/// <summary>
		/// 空襲被害の状態を表す文字列を取得します。(短縮版)
		/// </summary>
		public static string GetAirRaidDamageShort(int value)
		{
			switch (value)
			{
				case 1:
					return "資源損害";
				case 2:
					return "資源・航空";
				case 3:
					return "航空隊損害";
				case 4:
					return "損害なし";
				default:
					return "-";
			}
		}


		#endregion


		#region 戦闘

		/// <summary>
		/// 陣形を表す文字列を取得します。
		/// </summary>
		public static string GetFormation(int id)
		{
			switch (id)
			{
				case 1:
					return "単縦陣";
				case 2:
					return "複縦陣";
				case 3:
					return "輪形陣";
				case 4:
					return "梯形陣";
				case 5:
					return "単横陣";
				case 6:
					return "警戒陣";
				case 11:
					return "第一警戒航行序列";
				case 12:
					return "第二警戒航行序列";
				case 13:
					return "第三警戒航行序列";
				case 14:
					return "第四警戒航行序列";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 陣形を表す数値を取得します。
		/// </summary>
		public static int GetFormation(string value)
		{
			switch (value)
			{
				case "単縦陣":
					return 1;
				case "複縦陣":
					return 2;
				case "輪形陣":
					return 3;
				case "梯形陣":
					return 4;
				case "単横陣":
					return 5;
				case "警戒陣":
					return 6;
				case "第一警戒航行序列":
					return 11;
				case "第二警戒航行序列":
					return 12;
				case "第三警戒航行序列":
					return 13;
				case "第四警戒航行序列":
					return 14;
				default:
					return -1;
			}
		}

		/// <summary>
		/// 陣形を表す文字列(短縮版)を取得します。
		/// </summary>
		public static string GetFormationShort(int id)
		{
			switch (id)
			{
				case 1:
					return "単縦陣";
				case 2:
					return "複縦陣";
				case 3:
					return "輪形陣";
				case 4:
					return "梯形陣";
				case 5:
					return "単横陣";
				case 6:
					return "警戒陣";
				case 11:
					return "第一警戒";
				case 12:
					return "第二警戒";
				case 13:
					return "第三警戒";
				case 14:
					return "第四警戒";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 交戦形態を表す文字列を取得します。
		/// </summary>
		public static string GetEngagementForm(int id)
		{
			switch (id)
			{
				case 1:
					return "同航戦";
				case 2:
					return "反航戦";
				case 3:
					return "T字有利";
				case 4:
					return "T字不利";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 索敵結果を表す文字列を取得します。
		/// </summary>
		public static string GetSearchingResult(int id)
		{
			switch (id)
			{
				case 1:
					return "成功";
				case 2:
					return "成功(未帰還有)";
				case 3:
					return "未帰還";
				case 4:
					return "失敗";
				case 5:
					return "成功(非索敵機)";
				case 6:
					return "失敗(非索敵機)";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 索敵結果を表す文字列(短縮版)を取得します。
		/// </summary>
		public static string GetSearchingResultShort(int id)
		{
			switch (id)
			{
				case 1:
					return "成功";
				case 2:
					return "成功△";
				case 3:
					return "未帰還";
				case 4:
					return "失敗";
				case 5:
					return "成功";
				case 6:
					return "失敗";
				default:
					return "不明";
			}
		}

		/// <summary>
		/// 制空戦の結果を表す文字列を取得します。
		/// </summary>
		public static string GetAirSuperiority(int id)
		{
			switch (id)
			{
				case 0:
					return "航空均衡";
				case 1:
					return "制空権確保";
				case 2:
					return "航空優勢";
				case 3:
					return "航空劣勢";
				case 4:
					return "制空権喪失";
				default:
					return "不明";
			}
		}



		/// <summary>
		/// 昼戦攻撃種別を表す文字列を取得します。
		/// </summary>
		public static string GetDayAttackKind(DayAttackKind id)
		{
			switch (id)
			{
				case DayAttackKind.NormalAttack:
					return "通常攻撃";
				case DayAttackKind.Laser:
					return "レーザー攻撃";
				case DayAttackKind.DoubleShelling:
					return "連続射撃";
				case DayAttackKind.CutinMainSub:
					return "カットイン(主砲/副砲)";
				case DayAttackKind.CutinMainRadar:
					return "カットイン(主砲/電探)";
				case DayAttackKind.CutinMainAP:
					return "カットイン(主砲/徹甲)";
				case DayAttackKind.CutinMainMain:
					return "カットイン(主砲/主砲)";
				case DayAttackKind.CutinAirAttack:
					return "空母カットイン";
				case DayAttackKind.Shelling:
					return "砲撃";
				case DayAttackKind.AirAttack:
					return "空撃";
				case DayAttackKind.DepthCharge:
					return "爆雷攻撃";
				case DayAttackKind.Torpedo:
					return "雷撃";
				case DayAttackKind.Rocket:
					return "ロケット砲撃";
				case DayAttackKind.LandingDaihatsu:
					return "揚陸攻撃(大発動艇)";
				case DayAttackKind.LandingTokuDaihatsu:
					return "揚陸攻撃(特大発動艇)";
				case DayAttackKind.LandingDaihatsuTank:
					return "揚陸攻撃(大発戦車)";
				case DayAttackKind.LandingAmphibious:
					return "揚陸攻撃(内火艇)";
				case DayAttackKind.LandingTokuDaihatsuTank:
					return "揚陸攻撃(特大発戦車)";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 夜戦攻撃種別を表す文字列を取得します。
		/// </summary>
		public static string GetNightAttackKind(NightAttackKind id)
		{
			switch (id)
			{
				case NightAttackKind.NormalAttack:
					return "通常攻撃";
				case NightAttackKind.DoubleShelling:
					return "連続射撃";
				case NightAttackKind.CutinMainTorpedo:
					return "カットイン(主砲/魚雷)";
				case NightAttackKind.CutinTorpedoTorpedo:
					return "カットイン(魚雷x2)";
				case NightAttackKind.CutinMainSub:
					return "カットイン(主砲x2/副砲)";
				case NightAttackKind.CutinMainMain:
					return "カットイン(主砲x3)";
				case NightAttackKind.CutinAirAttack:
					return "空母カットイン";
				case NightAttackKind.CutinTorpedoRadar:
					return "駆逐カットイン(主砲/魚雷/電探)";
				case NightAttackKind.CutinTorpedoPicket:
					return "駆逐カットイン(魚雷/見張員/電探)";
				case NightAttackKind.Shelling:
					return "砲撃";
				case NightAttackKind.AirAttack:
					return "空撃";
				case NightAttackKind.DepthCharge:
					return "爆雷攻撃";
				case NightAttackKind.Torpedo:
					return "雷撃";
				case NightAttackKind.Rocket:
					return "ロケット砲撃";
				case NightAttackKind.LandingDaihatsu:
					return "揚陸攻撃(大発動艇)";
				case NightAttackKind.LandingTokuDaihatsu:
					return "揚陸攻撃(特大発動艇)";
				case NightAttackKind.LandingDaihatsuTank:
					return "揚陸攻撃(大発戦車)";
				case NightAttackKind.LandingAmphibious:
					return "揚陸攻撃(内火艇)";
				case NightAttackKind.LandingTokuDaihatsuTank:
					return "揚陸攻撃(特大発戦車)";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 対空カットイン種別を表す文字列を取得します。
		/// </summary>
		public static string GetAACutinKind(int id)
		{
			switch (id)
			{
				case 0:
					return "なし";
				case 1:
					return "高角砲x2/電探(秋月)";
				case 2:
					return "高角砲/電探(秋月)";
				case 3:
					return "高角砲x2(秋月)";
				case 4:
					return "大口径主砲/三式弾/高射装置/電探";
				case 5:
					return "高角砲+高射装置x2/電探";
				case 6:
					return "大口径主砲/三式弾/高射装置";
				case 7:
					return "高角砲/高射装置/電探";
				case 8:
					return "高角砲+高射装置/電探";
				case 9:
					return "高角砲/高射装置";
				case 10:
					return "高角砲/集中機銃/電探(摩耶)";
				case 11:
					return "高角砲/集中機銃(摩耶)";
				case 12:
					return "集中機銃/機銃/電探";
				case 14:
					return "高角砲/機銃/電探(五十鈴)";
				case 15:
					return "高角砲/機銃(五十鈴)";
				case 16:
					return "高角砲/機銃/電探(霞)";
				case 17:
					return "高角砲/機銃(霞)";
				case 18:
					return "集中機銃(皐月)";
				case 19:
					return "高角砲(非高射装置)/集中機銃(鬼怒)";
				case 20:
					return "集中機銃(鬼怒)";
				case 21:
					return "高角砲/電探(由良)";
				case 22:
					return "集中機銃(文月)";
				case 23:
					return "機銃(非集中)(UIT-25)";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 勝利ランクを表すIDを取得します。
		/// </summary>
		public static int GetWinRank(string rank)
		{
			switch (rank.ToUpper())
			{
				case "E":
					return 1;
				case "D":
					return 2;
				case "C":
					return 3;
				case "B":
					return 4;
				case "A":
					return 5;
				case "S":
					return 6;
				case "SS":
					return 7;
				default:
					return 0;
			}
		}

		/// <summary>
		/// 勝利ランクを表す文字列を取得します。
		/// </summary>
		public static string GetWinRank(int rank)
		{
			switch (rank)
			{
				case 1:
					return "E";
				case 2:
					return "D";
				case 3:
					return "C";
				case 4:
					return "B";
				case 5:
					return "A";
				case 6:
					return "S";
				case 7:
					return "SS";
				default:
					return "不明";
			}
		}

		#endregion


		#region その他

		/// <summary>
		/// 資源の名前を取得します。
		/// </summary>
		/// <param name="materialID">資源のID。</param>
		/// <returns>資源の名前。</returns>
		public static string GetMaterialName(int materialID)
		{

			switch (materialID)
			{
				case 1:
					return "燃料";
				case 2:
					return "弾薬";
				case 3:
					return "鋼材";
				case 4:
					return "ボーキサイト";
				case 5:
					return "高速建造材";
				case 6:
					return "高速修復材";
				case 7:
					return "開発資材";
				case 8:
					return "改修資材";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 階級を表す文字列を取得します。
		/// </summary>
		public static string GetAdmiralRank(int id)
		{
			switch (id)
			{
				case 1:
					return "元帥";
				case 2:
					return "大将";
				case 3:
					return "中将";
				case 4:
					return "少将";
				case 5:
					return "大佐";
				case 6:
					return "中佐";
				case 7:
					return "新米中佐";
				case 8:
					return "少佐";
				case 9:
					return "中堅少佐";
				case 10:
					return "新米少佐";
				default:
					return "提督";
			}
		}


		/// <summary>
		/// 任務の発生タイプを表す文字列を取得します。
		/// </summary>
		public static string GetQuestType(int id)
		{
			switch (id)
			{
				case 1:     //デイリー
					return "日";
				case 2:     //ウィークリー
					return "週";
				case 3:     //マンスリー
					return "月";
				case 4:     //単発
					return "単";
				case 5:     //その他(輸送5/空母3)
					return "他";
				default:
					return "?";
			}

		}


		/// <summary>
		/// 任務のカテゴリを表す文字列を取得します。
		/// </summary>
		public static string GetQuestCategory(int id)
		{
			switch (id)
			{
				case 1:
					return "編成";
				case 2:
					return "出撃";
				case 3:
					return "演習";
				case 4:
					return "遠征";
				case 5:
					return "補給";        //入渠も含むが、文字数の関係
				case 6:
					return "工廠";
				case 7:
					return "改装";
				case 8:
					return "出撃";
				case 9:
					return "他";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 遠征の結果を表す文字列を取得します。
		/// </summary>
		public static string GetExpeditionResult(int value)
		{
			switch (value)
			{
				case 0:
					return "失敗";
				case 1:
					return "成功";
				case 2:
					return "大成功";
				default:
					return "不明";
			}
		}


		/// <summary>
		/// 連合艦隊の編成名を表す文字列を取得します。
		/// </summary>
		public static string GetCombinedFleet(int value)
		{
			switch (value)
			{
				case 0:
					return "通常艦隊";
				case 1:
					return "機動部隊";
				case 2:
					return "水上部隊";
				case 3:
					return "輸送部隊";
				default:
					return "不明";
			}
		}

		#endregion

	}

}
