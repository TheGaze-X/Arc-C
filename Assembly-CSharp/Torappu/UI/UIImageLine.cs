using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003803 RID: 14339
	[Token(Token = "0x2003803")]
	[RequireComponent(typeof(Image))]
	[RequireComponent(typeof(RectTransform))]
	public class UIImageLine : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x06016B69 RID: 93033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700364E")]
		public Image image
		{
			[Token(Token = "0x6016B69")]
			[Address(RVA = "0xF16EC0", Offset = "0xF15AC0", VA = "0x180F16EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x06016B6A RID: 93034 RVA: 0x00092730 File Offset: 0x00090930
		// (set) Token: 0x06016B6B RID: 93035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700364F")]
		public float lineWidth
		{
			[Token(Token = "0x6016B6A")]
			[Address(RVA = "0xF16FF0", Offset = "0xF15BF0", VA = "0x180F16FF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6016B6B")]
			[Address(RVA = "0xF17190", Offset = "0xF15D90", VA = "0x180F17190")]
			set
			{
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x06016B6C RID: 93036 RVA: 0x00092748 File Offset: 0x00090948
		// (set) Token: 0x06016B6D RID: 93037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003650")]
		public float lineAlign
		{
			[Token(Token = "0x6016B6C")]
			[Address(RVA = "0xF16F90", Offset = "0xF15B90", VA = "0x180F16F90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6016B6D")]
			[Address(RVA = "0xF17120", Offset = "0xF15D20", VA = "0x180F17120")]
			set
			{
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x06016B6E RID: 93038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003651")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x6016B6E")]
			[Address(RVA = "0xF17050", Offset = "0xF15C50", VA = "0x180F17050")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B6F RID: 93039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B6F")]
		[Address(RVA = "0xF16A40", Offset = "0xF15640", VA = "0x180F16A40")]
		public void LineTo(Vector2 start, Vector2 end, [Optional] RectTransform local)
		{
		}

		// Token: 0x06016B70 RID: 93040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B70")]
		[Address(RVA = "0xF16D10", Offset = "0xF15910", VA = "0x180F16D10")]
		private void _UpdateConfig(float length)
		{
		}

		// Token: 0x06016B71 RID: 93041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B71")]
		[Address(RVA = "0xF16E50", Offset = "0xF15A50", VA = "0x180F16E50")]
		public UIImageLine()
		{
		}

		// Token: 0x0401B5E7 RID: 112103
		[Token(Token = "0x401B5E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _lineWidth;

		// Token: 0x0401B5E8 RID: 112104
		[Token(Token = "0x401B5E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("povit of y")]
		private float _lineAlign;

		// Token: 0x0401B5E9 RID: 112105
		[Token(Token = "0x401B5E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image m_image;

		// Token: 0x0401B5EA RID: 112106
		[Token(Token = "0x401B5EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform m_rectTrans;

		// Token: 0x0401B5EB RID: 112107
		[Token(Token = "0x401B5EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_image;

		// Token: 0x0401B5EC RID: 112108
		[Token(Token = "0x401B5EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lineWidth;

		// Token: 0x0401B5ED RID: 112109
		[Token(Token = "0x401B5ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_lineWidth;

		// Token: 0x0401B5EE RID: 112110
		[Token(Token = "0x401B5EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lineAlign;

		// Token: 0x0401B5EF RID: 112111
		[Token(Token = "0x401B5EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_lineAlign;

		// Token: 0x0401B5F0 RID: 112112
		[Token(Token = "0x401B5F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x0401B5F1 RID: 112113
		[Token(Token = "0x401B5F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LineTo;

		// Token: 0x0401B5F2 RID: 112114
		[Token(Token = "0x401B5F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateConfig;

		// Token: 0x0401B5F3 RID: 112115
		[Token(Token = "0x401B5F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
