using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F52 RID: 24402
	[Token(Token = "0x2005F52")]
	public class CharacterInfoIllustController : DataBinder<CharacterIllustViewProperty>
	{
		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x0602354F RID: 144719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005387")]
		public UICharacterIllust illust
		{
			[Token(Token = "0x602354F")]
			[Address(RVA = "0x1DD7DA0", Offset = "0x1DD69A0", VA = "0x181DD7DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023550 RID: 144720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023550")]
		[Address(RVA = "0x1DD7AB0", Offset = "0x1DD66B0", VA = "0x181DD7AB0", Slot = "7")]
		public override void OnValueChanged(CharacterIllustViewProperty property)
		{
		}

		// Token: 0x06023551 RID: 144721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023551")]
		[Address(RVA = "0x1DD7CD0", Offset = "0x1DD68D0", VA = "0x181DD7CD0")]
		public CharacterInfoIllustController()
		{
		}

		// Token: 0x04030C0C RID: 199692
		[Token(Token = "0x4030C0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _illustWrapperPrefab;

		// Token: 0x04030C0D RID: 199693
		[Token(Token = "0x4030C0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _illustLayout;

		// Token: 0x04030C0E RID: 199694
		[Token(Token = "0x4030C0E")]
		[FieldOffset(Offset = "0x30")]
		private IllustCache m_cache;

		// Token: 0x04030C0F RID: 199695
		[Token(Token = "0x4030C0F")]
		[FieldOffset(Offset = "0x58")]
		private CharacterInfoIllustWrapper m_illustWrappers;

		// Token: 0x04030C10 RID: 199696
		[Token(Token = "0x4030C10")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030C11 RID: 199697
		[Token(Token = "0x4030C11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_illust;

		// Token: 0x04030C12 RID: 199698
		[Token(Token = "0x4030C12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030C13 RID: 199699
		[Token(Token = "0x4030C13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F53 RID: 24403
		[Token(Token = "0x2005F53")]
		[Serializable]
		public class IllustChangeEvent : UnityEvent<int>
		{
			// Token: 0x06023552 RID: 144722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023552")]
			[Address(RVA = "0x1DE3B10", Offset = "0x1DE2710", VA = "0x181DE3B10")]
			public IllustChangeEvent()
			{
			}
		}
	}
}
