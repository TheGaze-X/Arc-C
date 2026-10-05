using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007265 RID: 29285
	[Token(Token = "0x2007265")]
	public class Act5D1RuneStageStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x060297DC RID: 169948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297DC")]
		[Address(RVA = "0x24E8140", Offset = "0x24E6D40", VA = "0x1824E8140")]
		public void Refresh()
		{
		}

		// Token: 0x060297DD RID: 169949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297DD")]
		[Address(RVA = "0x24E7AF0", Offset = "0x24E66F0", VA = "0x1824E7AF0")]
		public void InitRuneInfo(string runeReId, string stageId)
		{
		}

		// Token: 0x060297DE RID: 169950 RVA: 0x000D5C90 File Offset: 0x000D3E90
		[Token(Token = "0x60297DE")]
		[Address(RVA = "0x24E7A50", Offset = "0x24E6650", VA = "0x1824E7A50")]
		public int GetRuneWarningLine()
		{
			return 0;
		}

		// Token: 0x060297DF RID: 169951 RVA: 0x000D5CA8 File Offset: 0x000D3EA8
		[Token(Token = "0x60297DF")]
		[Address(RVA = "0x24E7900", Offset = "0x24E6500", VA = "0x1824E7900")]
		public int GetPointCount()
		{
			return 0;
		}

		// Token: 0x060297E0 RID: 169952 RVA: 0x000D5CC0 File Offset: 0x000D3EC0
		[Token(Token = "0x60297E0")]
		[Address(RVA = "0x24E7800", Offset = "0x24E6400", VA = "0x1824E7800")]
		public bool GetNewHandFlag()
		{
			return default(bool);
		}

		// Token: 0x060297E1 RID: 169953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297E1")]
		[Address(RVA = "0x24E7670", Offset = "0x24E6270", VA = "0x1824E7670")]
		public List<string> GetBanList()
		{
			return null;
		}

		// Token: 0x060297E2 RID: 169954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297E2")]
		[Address(RVA = "0x24E8370", Offset = "0x24E6F70", VA = "0x1824E8370")]
		public Act5D1RuneStageStateBean()
		{
		}

		// Token: 0x0403B4A6 RID: 242854
		[Token(Token = "0x403B4A6")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<RuneInfo> runeList;

		// Token: 0x0403B4A7 RID: 242855
		[Token(Token = "0x403B4A7")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string cacheStageId;

		// Token: 0x0403B4A8 RID: 242856
		[Token(Token = "0x403B4A8")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string cacheRuneReId;

		// Token: 0x0403B4A9 RID: 242857
		[Token(Token = "0x403B4A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403B4AA RID: 242858
		[Token(Token = "0x403B4AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitRuneInfo;

		// Token: 0x0403B4AB RID: 242859
		[Token(Token = "0x403B4AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRuneWarningLine;

		// Token: 0x0403B4AC RID: 242860
		[Token(Token = "0x403B4AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPointCount;

		// Token: 0x0403B4AD RID: 242861
		[Token(Token = "0x403B4AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNewHandFlag;

		// Token: 0x0403B4AE RID: 242862
		[Token(Token = "0x403B4AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBanList;

		// Token: 0x0403B4AF RID: 242863
		[Token(Token = "0x403B4AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
