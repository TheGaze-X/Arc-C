using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	public class PrefabMark : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B80 RID: 23424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAD")]
		[Inspect]
		public GameObject prefab
		{
			[Token(Token = "0x6005B7F")]
			[Address(RVA = "0x1AF86F0", Offset = "0x1AF72F0", VA = "0x181AF86F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B80")]
			[Address(RVA = "0x1AF87B0", Offset = "0x1AF73B0", VA = "0x181AF87B0")]
			set
			{
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x0002EE60 File Offset: 0x0002D060
		// (set) Token: 0x06005B82 RID: 23426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAE")]
		[Inspect]
		public bool showMark
		{
			[Token(Token = "0x6005B81")]
			[Address(RVA = "0x1AF8750", Offset = "0x1AF7350", VA = "0x181AF8750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B82")]
			[Address(RVA = "0x1AF88D0", Offset = "0x1AF74D0", VA = "0x181AF88D0")]
			set
			{
			}
		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0x1AF8500", Offset = "0x1AF7100", VA = "0x181AF8500")]
		private void _RefreshInst()
		{
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0x1AF84A0", Offset = "0x1AF70A0", VA = "0x181AF84A0")]
		private void Awake()
		{
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0x1AF8690", Offset = "0x1AF7290", VA = "0x181AF8690")]
		public PrefabMark()
		{
		}

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private GameObject _markPrefab;

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private bool _markVisible;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_prefabInst;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prefab;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_prefab;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showMark;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showMark;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshInst;

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
