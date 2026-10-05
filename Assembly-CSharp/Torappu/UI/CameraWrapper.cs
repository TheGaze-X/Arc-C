using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003640 RID: 13888
	[Token(Token = "0x2003640")]
	public struct CameraWrapper
	{
		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x060161B5 RID: 90549 RVA: 0x0008F700 File Offset: 0x0008D900
		[Token(Token = "0x17003527")]
		public bool isEmpty
		{
			[Token(Token = "0x60161B5")]
			[Address(RVA = "0xE8EE70", Offset = "0xE8DA70", VA = "0x180E8EE70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060161B6 RID: 90550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161B6")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		public CameraWrapper(Camera camera)
		{
		}

		// Token: 0x060161B7 RID: 90551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161B7")]
		[Address(RVA = "0xE8EE40", Offset = "0xE8DA40", VA = "0x180E8EE40")]
		public void BindToCanvas(Canvas canvas)
		{
		}

		// Token: 0x060161B8 RID: 90552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60161B8")]
		[Address(RVA = "0xE8EC80", Offset = "0xE8D880", VA = "0x180E8EC80")]
		public void BindToBlurOnlyList(IList<Camera> blurList)
		{
		}

		// Token: 0x0401A957 RID: 108887
		[Token(Token = "0x401A957")]
		[FieldOffset(Offset = "0x0")]
		private Camera m_camera;
	}
}
