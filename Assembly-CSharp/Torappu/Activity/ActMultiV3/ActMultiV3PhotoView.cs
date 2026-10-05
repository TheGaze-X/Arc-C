using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F65 RID: 28517
	[Token(Token = "0x2006F65")]
	public class ActMultiV3PhotoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287D6 RID: 165846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D6")]
		[Address(RVA = "0x23CFE30", Offset = "0x23CEA30", VA = "0x1823CFE30")]
		public void Render(string actId, string photoBg, List<ActMultiV3PhotoCharViewModel> charModels)
		{
		}

		// Token: 0x060287D7 RID: 165847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D7")]
		[Address(RVA = "0x23CFF30", Offset = "0x23CEB30", VA = "0x1823CFF30")]
		private void _LoadCharacterSpines(List<ActMultiV3PhotoCharViewModel> charModels)
		{
		}

		// Token: 0x060287D8 RID: 165848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D8")]
		[Address(RVA = "0x23D0250", Offset = "0x23CEE50", VA = "0x1823D0250")]
		public ActMultiV3PhotoView()
		{
		}

		// Token: 0x040399DE RID: 235998
		[Token(Token = "0x40399DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x040399DF RID: 235999
		[Token(Token = "0x40399DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _characterHolder;

		// Token: 0x040399E0 RID: 236000
		[Token(Token = "0x40399E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3PhotoCharacter _characterSpinePrefab;

		// Token: 0x040399E1 RID: 236001
		[Token(Token = "0x40399E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _characterGraphic;

		// Token: 0x040399E2 RID: 236002
		[Token(Token = "0x40399E2")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedPhotoBg;

		// Token: 0x040399E3 RID: 236003
		[Token(Token = "0x40399E3")]
		[FieldOffset(Offset = "0x40")]
		private List<ActMultiV3PhotoCharacter> m_characters;

		// Token: 0x040399E4 RID: 236004
		[Token(Token = "0x40399E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399E5 RID: 236005
		[Token(Token = "0x40399E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadCharacterSpines;

		// Token: 0x040399E6 RID: 236006
		[Token(Token = "0x40399E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
