using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032FF RID: 13055
	[Token(Token = "0x20032FF")]
	public class UIBattleSystemMenuCostReturn : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014BCA RID: 84938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BCA")]
		[Address(RVA = "0xD22100", Offset = "0xD20D00", VA = "0x180D22100")]
		public void SetData(UIBattleSystemMenuCostReturn.ViewStruct viewStruct)
		{
		}

		// Token: 0x06014BCB RID: 84939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BCB")]
		[Address(RVA = "0xD22390", Offset = "0xD20F90", VA = "0x180D22390")]
		public UIBattleSystemMenuCostReturn()
		{
		}

		// Token: 0x04018A65 RID: 100965
		[Token(Token = "0x4018A65")]
		public const int BUFF_COST_RETURN = 1;

		// Token: 0x04018A66 RID: 100966
		[Token(Token = "0x4018A66")]
		private const string AP_RETURN_TEXT_FORMAT = "+{0}";

		// Token: 0x04018A67 RID: 100967
		[Token(Token = "0x4018A67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textReturn;

		// Token: 0x04018A68 RID: 100968
		[Token(Token = "0x4018A68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _descriptionLabel;

		// Token: 0x04018A69 RID: 100969
		[Token(Token = "0x4018A69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconAp;

		// Token: 0x04018A6A RID: 100970
		[Token(Token = "0x4018A6A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconEt;

		// Token: 0x04018A6B RID: 100971
		[Token(Token = "0x4018A6B")]
		[FieldOffset(Offset = "0x38")]
		private string m_etOrBuffItemId;

		// Token: 0x04018A6C RID: 100972
		[Token(Token = "0x4018A6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018A6D RID: 100973
		[Token(Token = "0x4018A6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003300 RID: 13056
		[Token(Token = "0x2003300")]
		public struct ViewStruct : IHotfixable
		{
			// Token: 0x06014BCC RID: 84940 RVA: 0x000882A8 File Offset: 0x000864A8
			[Token(Token = "0x6014BCC")]
			[Address(RVA = "0xD30F50", Offset = "0xD2FB50", VA = "0x180D30F50")]
			public static UIBattleSystemMenuCostReturn.ViewStruct CreateModel(BattleInOut.InParams input, UIBattleSystemMenuPanel.BattleReward reward)
			{
				return default(UIBattleSystemMenuCostReturn.ViewStruct);
			}

			// Token: 0x04018A6E RID: 100974
			[Token(Token = "0x4018A6E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBattleSystemMenuCostReturn.ViewStruct EMPTY;

			// Token: 0x04018A6F RID: 100975
			[Token(Token = "0x4018A6F")]
			[FieldOffset(Offset = "0x0")]
			public bool isUsingEtOrBuff;

			// Token: 0x04018A70 RID: 100976
			[Token(Token = "0x4018A70")]
			[FieldOffset(Offset = "0x1")]
			public bool isApProtect;

			// Token: 0x04018A71 RID: 100977
			[Token(Token = "0x4018A71")]
			[FieldOffset(Offset = "0x2")]
			public bool inApProtectPeriod;

			// Token: 0x04018A72 RID: 100978
			[Token(Token = "0x4018A72")]
			[FieldOffset(Offset = "0x8")]
			public string apItemName;

			// Token: 0x04018A73 RID: 100979
			[Token(Token = "0x4018A73")]
			[FieldOffset(Offset = "0x10")]
			public string desc;

			// Token: 0x04018A74 RID: 100980
			[Token(Token = "0x4018A74")]
			[FieldOffset(Offset = "0x18")]
			public int costReturn;

			// Token: 0x04018A75 RID: 100981
			[Token(Token = "0x4018A75")]
			[FieldOffset(Offset = "0x20")]
			public string etOrBuffItemId;

			// Token: 0x04018A76 RID: 100982
			[Token(Token = "0x4018A76")]
			[FieldOffset(Offset = "0x28")]
			public string etOrBuffItemName;

			// Token: 0x04018A77 RID: 100983
			[Token(Token = "0x4018A77")]
			[FieldOffset(Offset = "0x30")]
			public string etOrBuffIconId;

			// Token: 0x04018A78 RID: 100984
			[Token(Token = "0x4018A78")]
			[FieldOffset(Offset = "0x38")]
			public int etCost;

			// Token: 0x04018A79 RID: 100985
			[Token(Token = "0x4018A79")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CreateModel;
		}
	}
}
