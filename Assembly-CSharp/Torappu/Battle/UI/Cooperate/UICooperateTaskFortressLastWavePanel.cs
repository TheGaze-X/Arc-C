using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F3 RID: 13299
	[Token(Token = "0x20033F3")]
	public class UICooperateTaskFortressLastWavePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015390 RID: 86928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015390")]
		[Address(RVA = "0xDABB30", Offset = "0xDAA730", VA = "0x180DABB30")]
		public void InitPanel()
		{
		}

		// Token: 0x06015391 RID: 86929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015391")]
		[Address(RVA = "0xDABC90", Offset = "0xDAA890", VA = "0x180DABC90")]
		public void UpdatePanel(float damage)
		{
		}

		// Token: 0x06015392 RID: 86930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015392")]
		[Address(RVA = "0xDABE00", Offset = "0xDAAA00", VA = "0x180DABE00")]
		public UICooperateTaskFortressLastWavePanel()
		{
		}

		// Token: 0x040195A0 RID: 103840
		[Token(Token = "0x40195A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _waveDamage;

		// Token: 0x040195A1 RID: 103841
		[Token(Token = "0x40195A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x040195A2 RID: 103842
		[Token(Token = "0x40195A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195A3 RID: 103843
		[Token(Token = "0x40195A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
