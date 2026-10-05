using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046C9 RID: 18121
	[Token(Token = "0x20046C9")]
	public class RL04DifficultyRulesBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x0601B79F RID: 112543 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7A0 RID: 112544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004169")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B79F")]
			[Address(RVA = "0x14C47D0", Offset = "0x14C33D0", VA = "0x1814C47D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7A0")]
			[Address(RVA = "0x14C4830", Offset = "0x14C3430", VA = "0x1814C4830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B7A1 RID: 112545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7A1")]
		[Address(RVA = "0x14C44A0", Offset = "0x14C30A0", VA = "0x1814C44A0")]
		public void Render(RL04DifficultyRulesBuffModel model)
		{
		}

		// Token: 0x0601B7A2 RID: 112546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7A2")]
		[Address(RVA = "0x14C4770", Offset = "0x14C3370", VA = "0x1814C4770")]
		public RL04DifficultyRulesBuffItem()
		{
		}

		// Token: 0x04023951 RID: 145745
		[Token(Token = "0x4023951")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04023952 RID: 145746
		[Token(Token = "0x4023952")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buffName;

		// Token: 0x04023953 RID: 145747
		[Token(Token = "0x4023953")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _activeTips;

		// Token: 0x04023954 RID: 145748
		[Token(Token = "0x4023954")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _descs;

		// Token: 0x04023956 RID: 145750
		[Token(Token = "0x4023956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04023957 RID: 145751
		[Token(Token = "0x4023957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04023958 RID: 145752
		[Token(Token = "0x4023958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023959 RID: 145753
		[Token(Token = "0x4023959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
