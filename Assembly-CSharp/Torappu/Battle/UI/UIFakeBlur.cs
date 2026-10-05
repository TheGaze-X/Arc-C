using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003379 RID: 13177
	[Token(Token = "0x2003379")]
	public class UIFakeBlur : MonoBehaviour
	{
		// Token: 0x06015053 RID: 86099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015053")]
		[Address(RVA = "0xD6FE70", Offset = "0xD6EA70", VA = "0x180D6FE70", Slot = "4")]
		protected virtual List<Camera> GetBlurCameras()
		{
			return null;
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x06015054 RID: 86100 RVA: 0x0008A1C8 File Offset: 0x000883C8
		[Token(Token = "0x170031F3")]
		public bool isOn
		{
			[Token(Token = "0x6015054")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015055 RID: 86101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015055")]
		[Address(RVA = "0xD6FD60", Offset = "0xD6E960", VA = "0x180D6FD60")]
		public Coroutine Enter([Optional] Action finishCb)
		{
			return null;
		}

		// Token: 0x06015056 RID: 86102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015056")]
		[Address(RVA = "0xD6FF60", Offset = "0xD6EB60", VA = "0x180D6FF60")]
		public Coroutine Leave()
		{
			return null;
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015057")]
		[Address(RVA = "0xD700A0", Offset = "0xD6ECA0", VA = "0x180D700A0")]
		public Sprite ShotBlurBackground()
		{
			return null;
		}

		// Token: 0x06015058 RID: 86104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015058")]
		[Address(RVA = "0xD70090", Offset = "0xD6EC90", VA = "0x180D70090")]
		public void SetSpriteColor(Color color)
		{
		}

		// Token: 0x06015059 RID: 86105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015059")]
		[Address(RVA = "0xD70140", Offset = "0xD6ED40", VA = "0x180D70140")]
		private void _ClearIfNot(bool keepSprite)
		{
		}

		// Token: 0x0601505A RID: 86106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601505A")]
		[Address(RVA = "0xD70250", Offset = "0xD6EE50", VA = "0x180D70250")]
		private IEnumerator _DoEnter(Action finishCb)
		{
			return null;
		}

		// Token: 0x0601505B RID: 86107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601505B")]
		[Address(RVA = "0xD702E0", Offset = "0xD6EEE0", VA = "0x180D702E0")]
		private IEnumerator _DoLeave()
		{
			return null;
		}

		// Token: 0x0601505C RID: 86108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601505C")]
		[Address(RVA = "0xD70360", Offset = "0xD6EF60", VA = "0x180D70360")]
		public UIFakeBlur()
		{
		}

		// Token: 0x0401903C RID: 102460
		[Token(Token = "0x401903C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFullScreenImage _fakeBlurImage;

		// Token: 0x0401903D RID: 102461
		[Token(Token = "0x401903D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x0401903E RID: 102462
		[Token(Token = "0x401903E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x0401903F RID: 102463
		[Token(Token = "0x401903F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Tweener m_tweener;

		// Token: 0x04019040 RID: 102464
		[Token(Token = "0x4019040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sprite m_fakeSprite;

		// Token: 0x04019041 RID: 102465
		[Token(Token = "0x4019041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_isOn;

		// Token: 0x04019042 RID: 102466
		[Token(Token = "0x4019042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine m_coroutine;

		// Token: 0x04019043 RID: 102467
		[Token(Token = "0x4019043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color m_fakeColor;
	}
}
