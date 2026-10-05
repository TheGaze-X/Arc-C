using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Sandbox;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C6 RID: 13254
	[Token(Token = "0x20033C6")]
	public class UIBattleSandboxResItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601525E RID: 86622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601525E")]
		[Address(RVA = "0xD94B70", Offset = "0xD93770", VA = "0x180D94B70")]
		public void OnInit(ResPackType resType)
		{
		}

		// Token: 0x0601525F RID: 86623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601525F")]
		[Address(RVA = "0xD94E50", Offset = "0xD93A50", VA = "0x180D94E50")]
		public void UpdateAmount(int resAmount, bool forceActive = false)
		{
		}

		// Token: 0x06015260 RID: 86624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015260")]
		[Address(RVA = "0xD94FD0", Offset = "0xD93BD0", VA = "0x180D94FD0")]
		public UIBattleSandboxResItem()
		{
		}

		// Token: 0x0401938F RID: 103311
		[Token(Token = "0x401938F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _resTypeIcon;

		// Token: 0x04019390 RID: 103312
		[Token(Token = "0x4019390")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _resRarityBack;

		// Token: 0x04019391 RID: 103313
		[Token(Token = "0x4019391")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _resAmountText;

		// Token: 0x04019392 RID: 103314
		[Token(Token = "0x4019392")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Config")]
		private UIAtlasObject _battleAtlas;

		// Token: 0x04019393 RID: 103315
		[Token(Token = "0x4019393")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Config")]
		private string[] _resRarityName;

		// Token: 0x04019394 RID: 103316
		[Token(Token = "0x4019394")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x04019395 RID: 103317
		[Token(Token = "0x4019395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019396 RID: 103318
		[Token(Token = "0x4019396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateAmount;

		// Token: 0x04019397 RID: 103319
		[Token(Token = "0x4019397")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
