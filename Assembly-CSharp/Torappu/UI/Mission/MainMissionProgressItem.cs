using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004890 RID: 18576
	[Token(Token = "0x2004890")]
	public class MainMissionProgressItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C0A2 RID: 114850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A2")]
		[Address(RVA = "0x1565830", Offset = "0x1564430", VA = "0x181565830")]
		public void Render(int target, int value)
		{
		}

		// Token: 0x0601C0A3 RID: 114851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A3")]
		[Address(RVA = "0x1565780", Offset = "0x1564380", VA = "0x181565780")]
		public void ApplyBarStyle(Color barColor)
		{
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0A4")]
		[Address(RVA = "0x1565960", Offset = "0x1564560", VA = "0x181565960")]
		public MainMissionProgressItem()
		{
		}

		// Token: 0x0402498C RID: 149900
		[Token(Token = "0x402498C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _processTargetLabel;

		// Token: 0x0402498D RID: 149901
		[Token(Token = "0x402498D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _processValueLabel;

		// Token: 0x0402498E RID: 149902
		[Token(Token = "0x402498E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _barImg;

		// Token: 0x0402498F RID: 149903
		[Token(Token = "0x402498F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MissionProgressBar _progressBar;

		// Token: 0x04024990 RID: 149904
		[Token(Token = "0x4024990")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024991 RID: 149905
		[Token(Token = "0x4024991")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyBarStyle;

		// Token: 0x04024992 RID: 149906
		[Token(Token = "0x4024992")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
