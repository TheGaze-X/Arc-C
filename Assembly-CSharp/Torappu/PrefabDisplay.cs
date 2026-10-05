using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	public class PrefabDisplay : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA9")]
		[Inspect]
		public GameObject prefab
		{
			[Token(Token = "0x6005B73")]
			[Address(RVA = "0x1AF8000", Offset = "0x1AF6C00", VA = "0x181AF8000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0x1AF8060", Offset = "0x1AF6C60", VA = "0x181AF8060")]
			set
			{
			}
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x1AF7D30", Offset = "0x1AF6930", VA = "0x181AF7D30")]
		[Inspect]
		public void Clear()
		{
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAA")]
		public GameObject inst
		{
			[Token(Token = "0x6005B76")]
			[Address(RVA = "0x1AF7FA0", Offset = "0x1AF6BA0", VA = "0x181AF7FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x1AF7E00", Offset = "0x1AF6A00", VA = "0x181AF7E00")]
		private void _RefreshInst()
		{
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x1AF7DA0", Offset = "0x1AF69A0", VA = "0x181AF7DA0")]
		public void OnApplyInst()
		{
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B79")]
		[Address(RVA = "0x1AF7CD0", Offset = "0x1AF68D0", VA = "0x181AF7CD0")]
		private void Awake()
		{
		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0x1AF7F40", Offset = "0x1AF6B40", VA = "0x181AF7F40")]
		public PrefabDisplay()
		{
		}

		// Token: 0x04002101 RID: 8449
		[Token(Token = "0x4002101")]
		[FieldOffset(Offset = "0x18")]
		private GameObject _prefab;

		// Token: 0x04002102 RID: 8450
		[Token(Token = "0x4002102")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_prefabInst;

		// Token: 0x04002103 RID: 8451
		[Token(Token = "0x4002103")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prefab;

		// Token: 0x04002104 RID: 8452
		[Token(Token = "0x4002104")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_prefab;

		// Token: 0x04002105 RID: 8453
		[Token(Token = "0x4002105")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04002106 RID: 8454
		[Token(Token = "0x4002106")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inst;

		// Token: 0x04002107 RID: 8455
		[Token(Token = "0x4002107")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshInst;

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnApplyInst;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
