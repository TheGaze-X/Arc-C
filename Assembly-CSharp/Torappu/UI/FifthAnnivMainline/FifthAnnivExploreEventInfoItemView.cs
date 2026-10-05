using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EAB RID: 20139
	[Token(Token = "0x2004EAB")]
	public class FifthAnnivExploreEventInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E0CA RID: 123082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0CA")]
		[Address(RVA = "0x17BAFC0", Offset = "0x17B9BC0", VA = "0x1817BAFC0")]
		public void Render(int position, FifthAnnivExplorePlanModel planModel)
		{
		}

		// Token: 0x0601E0CB RID: 123083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0CB")]
		[Address(RVA = "0x17BAEC0", Offset = "0x17B9AC0", VA = "0x1817BAEC0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0601E0CC RID: 123084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0CC")]
		[Address(RVA = "0x17BB2A0", Offset = "0x17B9EA0", VA = "0x1817BB2A0")]
		public FifthAnnivExploreEventInfoItemView()
		{
		}

		// Token: 0x04027F64 RID: 163684
		[Token(Token = "0x4027F64")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTypeName;

		// Token: 0x04027F65 RID: 163685
		[Token(Token = "0x4027F65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04027F66 RID: 163686
		[Token(Token = "0x4027F66")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _iconAtlas;

		// Token: 0x04027F67 RID: 163687
		[Token(Token = "0x4027F67")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04027F68 RID: 163688
		[Token(Token = "0x4027F68")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027F69 RID: 163689
		[Token(Token = "0x4027F69")]
		[FieldOffset(Offset = "0x48")]
		private string m_planId;

		// Token: 0x04027F6A RID: 163690
		[Token(Token = "0x4027F6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027F6B RID: 163691
		[Token(Token = "0x4027F6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04027F6C RID: 163692
		[Token(Token = "0x4027F6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
