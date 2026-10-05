using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E2 RID: 13026
	[Token(Token = "0x20032E2")]
	public class UIStageInfo : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014B56 RID: 84822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B56")]
		[Address(RVA = "0xD2EF10", Offset = "0xD2DB10", VA = "0x180D2EF10")]
		public void SetData(BattleStageInfo stageInfo)
		{
		}

		// Token: 0x06014B57 RID: 84823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B57")]
		[Address(RVA = "0xD2F130", Offset = "0xD2DD30", VA = "0x180D2F130")]
		public UIStageInfo()
		{
		}

		// Token: 0x0401898F RID: 100751
		[Token(Token = "0x401898F")]
		private const string OPERATION_TEXT = "Operation";

		// Token: 0x04018990 RID: 100752
		[Token(Token = "0x4018990")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageNoLabel;

		// Token: 0x04018991 RID: 100753
		[Token(Token = "0x4018991")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageNameLabel;

		// Token: 0x04018992 RID: 100754
		[Token(Token = "0x4018992")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageOperationLabel;

		// Token: 0x04018993 RID: 100755
		[Token(Token = "0x4018993")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018994 RID: 100756
		[Token(Token = "0x4018994")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
