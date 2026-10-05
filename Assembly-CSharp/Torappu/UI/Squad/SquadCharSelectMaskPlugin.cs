using System;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E0F RID: 15887
	[Token(Token = "0x2003E0F")]
	public class SquadCharSelectMaskPlugin : CharSelectCardMaskPlugin
	{
		// Token: 0x06018B73 RID: 101235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B73")]
		[Address(RVA = "0x1138790", Offset = "0x1137390", VA = "0x181138790", Slot = "4")]
		public override void Init(CharSelectCardView cardView, CharSelectStateBean stateBean, object context)
		{
		}

		// Token: 0x06018B74 RID: 101236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B74")]
		[Address(RVA = "0x1138900", Offset = "0x1137500", VA = "0x181138900", Slot = "5")]
		public override void Render(CharacterCardViewModel cardModel)
		{
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018B75")]
		[Address(RVA = "0x1138B50", Offset = "0x1137750", VA = "0x181138B50")]
		private string _GetMutuallyExclusiveInfo(int instId)
		{
			return null;
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B76")]
		[Address(RVA = "0x1139170", Offset = "0x1137D70", VA = "0x181139170")]
		public SquadCharSelectMaskPlugin()
		{
		}

		// Token: 0x0401E517 RID: 124183
		[Token(Token = "0x401E517")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelBlock;

		// Token: 0x0401E518 RID: 124184
		[Token(Token = "0x401E518")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textForbid;

		// Token: 0x0401E519 RID: 124185
		[Token(Token = "0x401E519")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelExclusiveInfo;

		// Token: 0x0401E51A RID: 124186
		[Token(Token = "0x401E51A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401E51B RID: 124187
		[Token(Token = "0x401E51B")]
		[FieldOffset(Offset = "0x38")]
		private CharSelectStateBean m_charSelectBean;

		// Token: 0x0401E51C RID: 124188
		[Token(Token = "0x401E51C")]
		[FieldOffset(Offset = "0x40")]
		private ISquadCharSelectContext m_context;

		// Token: 0x0401E51D RID: 124189
		[Token(Token = "0x401E51D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E51E RID: 124190
		[Token(Token = "0x401E51E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E51F RID: 124191
		[Token(Token = "0x401E51F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetMutuallyExclusiveInfo;

		// Token: 0x0401E520 RID: 124192
		[Token(Token = "0x401E520")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
