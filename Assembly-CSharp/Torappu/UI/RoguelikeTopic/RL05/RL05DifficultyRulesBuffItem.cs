using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x02004593 RID: 17811
	[Token(Token = "0x2004593")]
	public class RL05DifficultyRulesBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x0601B1CA RID: 111050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B1CB RID: 111051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700409B")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B1CA")]
			[Address(RVA = "0x144E240", Offset = "0x144CE40", VA = "0x18144E240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B1CB")]
			[Address(RVA = "0x144E2A0", Offset = "0x144CEA0", VA = "0x18144E2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B1CC RID: 111052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1CC")]
		[Address(RVA = "0x144DF10", Offset = "0x144CB10", VA = "0x18144DF10")]
		public void Render(RL05DifficultyRulesBuffModel model)
		{
		}

		// Token: 0x0601B1CD RID: 111053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1CD")]
		[Address(RVA = "0x144E1E0", Offset = "0x144CDE0", VA = "0x18144E1E0")]
		public RL05DifficultyRulesBuffItem()
		{
		}

		// Token: 0x04022E2E RID: 142894
		[Token(Token = "0x4022E2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04022E2F RID: 142895
		[Token(Token = "0x4022E2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04022E30 RID: 142896
		[Token(Token = "0x4022E30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _activeTips;

		// Token: 0x04022E31 RID: 142897
		[Token(Token = "0x4022E31")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _descs;

		// Token: 0x04022E33 RID: 142899
		[Token(Token = "0x4022E33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04022E34 RID: 142900
		[Token(Token = "0x4022E34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04022E35 RID: 142901
		[Token(Token = "0x4022E35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022E36 RID: 142902
		[Token(Token = "0x4022E36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
