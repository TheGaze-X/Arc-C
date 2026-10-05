using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	public class ClearAssets : SingletonMonoBehaviour<ClearAssets>, ISingletonNotAutoCreate
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x0002DA80 File Offset: 0x0002BC80
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000205")]
		public bool isClearing
		{
			[Token(Token = "0x6004D90")]
			[Address(RVA = "0x187F340", Offset = "0x187DF40", VA = "0x18187F340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D91")]
			[Address(RVA = "0x187F410", Offset = "0x187E010", VA = "0x18187F410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x0002DA98 File Offset: 0x0002BC98
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000206")]
		public bool isCleared
		{
			[Token(Token = "0x6004D92")]
			[Address(RVA = "0x187F2E0", Offset = "0x187DEE0", VA = "0x18187F2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D93")]
			[Address(RVA = "0x187F3A0", Offset = "0x187DFA0", VA = "0x18187F3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D94")]
		[Address(RVA = "0x187F080", Offset = "0x187DC80", VA = "0x18187F080")]
		public static IEnumerator ClearIfExists(bool force = false)
		{
			return null;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D95")]
		[Address(RVA = "0x187F1B0", Offset = "0x187DDB0", VA = "0x18187F1B0")]
		private IEnumerator _DoClear()
		{
			return null;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x187F120", Offset = "0x187DD20", VA = "0x18187F120", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x187F260", Offset = "0x187DE60", VA = "0x18187F260")]
		public ClearAssets()
		{
		}

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _clearOnAwake;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _unloadAll;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool _forceUnloadEvenUsed;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _excludedPrefixes;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isClearing;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isClearing;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isCleared;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isCleared;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearIfExists;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoClear;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
