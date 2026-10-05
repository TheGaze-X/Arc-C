using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045B6 RID: 17846
	[Token(Token = "0x20045B6")]
	public class RL03DifficultyRulesBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x0601B26B RID: 111211 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B26C RID: 111212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040AF")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B26B")]
			[Address(RVA = "0x14471F0", Offset = "0x1445DF0", VA = "0x1814471F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B26C")]
			[Address(RVA = "0x1447250", Offset = "0x1445E50", VA = "0x181447250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B26D RID: 111213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B26D")]
		[Address(RVA = "0x1446DD0", Offset = "0x14459D0", VA = "0x181446DD0")]
		public void Render(RL03DifficultyRulesBuffModel model)
		{
		}

		// Token: 0x0601B26E RID: 111214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B26E")]
		[Address(RVA = "0x1447190", Offset = "0x1445D90", VA = "0x181447190")]
		public RL03DifficultyRulesBuffItem()
		{
		}

		// Token: 0x04022F65 RID: 143205
		[Token(Token = "0x4022F65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04022F66 RID: 143206
		[Token(Token = "0x4022F66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04022F67 RID: 143207
		[Token(Token = "0x4022F67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _activeTips;

		// Token: 0x04022F68 RID: 143208
		[Token(Token = "0x4022F68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04022F6A RID: 143210
		[Token(Token = "0x4022F6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04022F6B RID: 143211
		[Token(Token = "0x4022F6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04022F6C RID: 143212
		[Token(Token = "0x4022F6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022F6D RID: 143213
		[Token(Token = "0x4022F6D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
