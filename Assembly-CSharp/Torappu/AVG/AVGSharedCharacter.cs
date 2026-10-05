using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F0D RID: 7949
	[Token(Token = "0x2001F0D")]
	public class AVGSharedCharacter : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x0600C538 RID: 50488 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C539 RID: 50489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001781")]
		public UnityEngine.Object cachedPrefab
		{
			[Token(Token = "0x600C538")]
			[Address(RVA = "0x342CFE0", Offset = "0x342BBE0", VA = "0x18342CFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C539")]
			[Address(RVA = "0x342D0A0", Offset = "0x342BCA0", VA = "0x18342D0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x0600C53A RID: 50490 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C53B RID: 50491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001782")]
		public string currCharKey
		{
			[Token(Token = "0x600C53A")]
			[Address(RVA = "0x342D040", Offset = "0x342BC40", VA = "0x18342D040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C53B")]
			[Address(RVA = "0x342D120", Offset = "0x342BD20", VA = "0x18342D120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53C")]
		[Address(RVA = "0x342B9A0", Offset = "0x342A5A0", VA = "0x18342B9A0")]
		public void SetCharacter(Func<string, GameObject> loadFunc, AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53D")]
		[Address(RVA = "0x342BE10", Offset = "0x342AA10", VA = "0x18342BE10")]
		public void SetCharacter(ILoadAsset loader, AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53E")]
		[Address(RVA = "0x342C150", Offset = "0x342AD50", VA = "0x18342C150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53F")]
		[Address(RVA = "0x342BFB0", Offset = "0x342ABB0", VA = "0x18342BFB0")]
		private void _FadeOutOldCharAndSetChar(Func<string, GameObject> loadFunc, AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C540")]
		[Address(RVA = "0x342CB80", Offset = "0x342B780", VA = "0x18342CB80")]
		private void _SetImage(Func<string, GameObject> loadFunc, AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x00048498 File Offset: 0x00046698
		[Token(Token = "0x600C541")]
		[Address(RVA = "0x342C2E0", Offset = "0x342AEE0", VA = "0x18342C2E0")]
		private bool _LoadImage(Func<string, GameObject> loadFunc, AVGSharedCharacter.Option option)
		{
			return default(bool);
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x000484B0 File Offset: 0x000466B0
		[Token(Token = "0x600C542")]
		[Address(RVA = "0x342CE60", Offset = "0x342BA60", VA = "0x18342CE60")]
		private static bool _TryParseBody(ref string key, out int body)
		{
			return default(bool);
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x000484C8 File Offset: 0x000466C8
		[Token(Token = "0x600C543")]
		[Address(RVA = "0x342CD40", Offset = "0x342B940", VA = "0x18342CD40")]
		private static bool _TryParseAlias(ref string key, out string alias)
		{
			return default(bool);
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C544")]
		[Address(RVA = "0x342CA70", Offset = "0x342B670", VA = "0x18342CA70")]
		private static void _ParseIndex(ref string key, out int index)
		{
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C545")]
		[Address(RVA = "0x342CF70", Offset = "0x342BB70", VA = "0x18342CF70")]
		public AVGSharedCharacter()
		{
		}

		// Token: 0x0400C9D9 RID: 51673
		[Token(Token = "0x400C9D9")]
		private const char INDEX_TOKEN = '#';

		// Token: 0x0400C9DA RID: 51674
		[Token(Token = "0x400C9DA")]
		private const char ALIAS_TOKEN = '@';

		// Token: 0x0400C9DB RID: 51675
		[Token(Token = "0x400C9DB")]
		private const char BODY_TOKEN = '$';

		// Token: 0x0400C9DC RID: 51676
		[Token(Token = "0x400C9DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Ease _fadeEade;

		// Token: 0x0400C9DD RID: 51677
		[Token(Token = "0x400C9DD")]
		[FieldOffset(Offset = "0x20")]
		private AlphaSplitImageHolder m_imageHolder;

		// Token: 0x0400C9DE RID: 51678
		[Token(Token = "0x400C9DE")]
		[FieldOffset(Offset = "0x28")]
		private Image m_charImage;

		// Token: 0x0400C9DF RID: 51679
		[Token(Token = "0x400C9DF")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400C9E2 RID: 51682
		[Token(Token = "0x400C9E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedPrefab;

		// Token: 0x0400C9E3 RID: 51683
		[Token(Token = "0x400C9E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cachedPrefab;

		// Token: 0x0400C9E4 RID: 51684
		[Token(Token = "0x400C9E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currCharKey;

		// Token: 0x0400C9E5 RID: 51685
		[Token(Token = "0x400C9E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_currCharKey;

		// Token: 0x0400C9E6 RID: 51686
		[Token(Token = "0x400C9E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetCharacter;

		// Token: 0x0400C9E7 RID: 51687
		[Token(Token = "0x400C9E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_SetCharacter;

		// Token: 0x0400C9E8 RID: 51688
		[Token(Token = "0x400C9E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400C9E9 RID: 51689
		[Token(Token = "0x400C9E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FadeOutOldCharAndSetChar;

		// Token: 0x0400C9EA RID: 51690
		[Token(Token = "0x400C9EA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetImage;

		// Token: 0x0400C9EB RID: 51691
		[Token(Token = "0x400C9EB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadImage;

		// Token: 0x0400C9EC RID: 51692
		[Token(Token = "0x400C9EC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryParseBody;

		// Token: 0x0400C9ED RID: 51693
		[Token(Token = "0x400C9ED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryParseAlias;

		// Token: 0x0400C9EE RID: 51694
		[Token(Token = "0x400C9EE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ParseIndex;

		// Token: 0x0400C9EF RID: 51695
		[Token(Token = "0x400C9EF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F0E RID: 7950
		[Token(Token = "0x2001F0E")]
		public class Option
		{
			// Token: 0x0600C546 RID: 50502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C546")]
			[Address(RVA = "0x3430200", Offset = "0x342EE00", VA = "0x183430200")]
			public Option()
			{
			}

			// Token: 0x0400C9F0 RID: 51696
			[Token(Token = "0x400C9F0")]
			[FieldOffset(Offset = "0x10")]
			public string avgCharKey;

			// Token: 0x0400C9F1 RID: 51697
			[Token(Token = "0x400C9F1")]
			[FieldOffset(Offset = "0x18")]
			public float blackStart;

			// Token: 0x0400C9F2 RID: 51698
			[Token(Token = "0x400C9F2")]
			[FieldOffset(Offset = "0x1C")]
			public float blackEnd;

			// Token: 0x0400C9F3 RID: 51699
			[Token(Token = "0x400C9F3")]
			[FieldOffset(Offset = "0x20")]
			public float fadeDuration;

			// Token: 0x0400C9F4 RID: 51700
			[Token(Token = "0x400C9F4")]
			[FieldOffset(Offset = "0x24")]
			public bool blackMaskInverse;
		}
	}
}
