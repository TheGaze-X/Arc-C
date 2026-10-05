using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F48 RID: 24392
	[Token(Token = "0x2005F48")]
	public class CharacterEvolveDetailNewSkillView : CharacterEvolveDetailCommon
	{
		// Token: 0x0602352C RID: 144684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352C")]
		[Address(RVA = "0x1DD44A0", Offset = "0x1DD30A0", VA = "0x181DD44A0")]
		public void Render(SkillData skillData)
		{
		}

		// Token: 0x0602352D RID: 144685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602352D")]
		[Address(RVA = "0x1DD4690", Offset = "0x1DD3290", VA = "0x181DD4690")]
		public CharacterEvolveDetailNewSkillView()
		{
		}

		// Token: 0x04030BD3 RID: 199635
		[Token(Token = "0x4030BD3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterInfoSkillView _skillView;

		// Token: 0x04030BD4 RID: 199636
		[Token(Token = "0x4030BD4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _title;

		// Token: 0x04030BD5 RID: 199637
		[Token(Token = "0x4030BD5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _level;

		// Token: 0x04030BD6 RID: 199638
		[Token(Token = "0x4030BD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030BD7 RID: 199639
		[Token(Token = "0x4030BD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
