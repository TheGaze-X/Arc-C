using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF9 RID: 28153
	[Token(Token = "0x2006DF9")]
	public class ActVecBreakV2MapEnemyBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028147 RID: 164167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028147")]
		[Address(RVA = "0x234F950", Offset = "0x234E550", VA = "0x18234F950")]
		public void Render(StageViewType viewType, Action onClickMapPreview, Action onClickEnemyDetail)
		{
		}

		// Token: 0x06028148 RID: 164168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028148")]
		[Address(RVA = "0x234F8E0", Offset = "0x234E4E0", VA = "0x18234F8E0")]
		public void OnClickMapPreview()
		{
		}

		// Token: 0x06028149 RID: 164169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028149")]
		[Address(RVA = "0x234F870", Offset = "0x234E470", VA = "0x18234F870")]
		public void OnClickEnemyDetail()
		{
		}

		// Token: 0x0602814A RID: 164170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602814A")]
		[Address(RVA = "0x234FC10", Offset = "0x234E810", VA = "0x18234FC10")]
		public ActVecBreakV2MapEnemyBtnView()
		{
		}

		// Token: 0x04038DD0 RID: 232912
		[Token(Token = "0x4038DD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageViewColorConfig[] _colorConfigs;

		// Token: 0x04038DD1 RID: 232913
		[Token(Token = "0x4038DD1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic[] _bgGraphics;

		// Token: 0x04038DD2 RID: 232914
		[Token(Token = "0x4038DD2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic[] _contentGraphics;

		// Token: 0x04038DD3 RID: 232915
		[Token(Token = "0x4038DD3")]
		[FieldOffset(Offset = "0x30")]
		private Action m_onClickMapPreview;

		// Token: 0x04038DD4 RID: 232916
		[Token(Token = "0x4038DD4")]
		[FieldOffset(Offset = "0x38")]
		private Action m_onClickEnemyDetail;

		// Token: 0x04038DD5 RID: 232917
		[Token(Token = "0x4038DD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038DD6 RID: 232918
		[Token(Token = "0x4038DD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickMapPreview;

		// Token: 0x04038DD7 RID: 232919
		[Token(Token = "0x4038DD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickEnemyDetail;

		// Token: 0x04038DD8 RID: 232920
		[Token(Token = "0x4038DD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
