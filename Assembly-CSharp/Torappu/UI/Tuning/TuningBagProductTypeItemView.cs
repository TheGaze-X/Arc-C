using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF2 RID: 15602
	[Token(Token = "0x2003CF2")]
	public class TuningBagProductTypeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601854B RID: 99659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601854B")]
		[Address(RVA = "0x10D8540", Offset = "0x10D7140", VA = "0x1810D8540")]
		public void Render(TuningProductBagProductGroupModel groupModel)
		{
		}

		// Token: 0x0601854C RID: 99660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601854C")]
		[Address(RVA = "0x10D84C0", Offset = "0x10D70C0", VA = "0x1810D84C0")]
		public void OnSelectProductType()
		{
		}

		// Token: 0x0601854D RID: 99661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601854D")]
		[Address(RVA = "0x10D8AA0", Offset = "0x10D76A0", VA = "0x1810D8AA0")]
		public TuningBagProductTypeItemView()
		{
		}

		// Token: 0x0401DBAF RID: 121775
		[Token(Token = "0x401DBAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _bgImage;

		// Token: 0x0401DBB0 RID: 121776
		[Token(Token = "0x401DBB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _selectImage;

		// Token: 0x0401DBB1 RID: 121777
		[Token(Token = "0x401DBB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _nonSelectImageObj;

		// Token: 0x0401DBB2 RID: 121778
		[Token(Token = "0x401DBB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _frameObj;

		// Token: 0x0401DBB3 RID: 121779
		[Token(Token = "0x401DBB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _typeNameText;

		// Token: 0x0401DBB4 RID: 121780
		[Token(Token = "0x401DBB4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lockTextColor;

		// Token: 0x0401DBB5 RID: 121781
		[Token(Token = "0x401DBB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _nonSelectTextColor;

		// Token: 0x0401DBB6 RID: 121782
		[Token(Token = "0x401DBB6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _selectTextColor;

		// Token: 0x0401DBB7 RID: 121783
		[Token(Token = "0x401DBB7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _productTypeBtn;

		// Token: 0x0401DBB8 RID: 121784
		[Token(Token = "0x401DBB8")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<string> onSelectProductType;

		// Token: 0x0401DBB9 RID: 121785
		[Token(Token = "0x401DBB9")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedProductTypeId;

		// Token: 0x0401DBBA RID: 121786
		[Token(Token = "0x401DBBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DBBB RID: 121787
		[Token(Token = "0x401DBBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectProductType;

		// Token: 0x0401DBBC RID: 121788
		[Token(Token = "0x401DBBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
