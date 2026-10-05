using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	[DisallowMultipleComponent]
	public class PrefabInstHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06005B7B RID: 23419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAB")]
		protected Transform prefabContainer
		{
			[Token(Token = "0x6005B7B")]
			[Address(RVA = "0x1AF8300", Offset = "0x1AF6F00", VA = "0x181AF8300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (set) Token: 0x06005B7C RID: 23420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CAC")]
		public Action<GameObject> achieveInst
		{
			[Token(Token = "0x6005B7C")]
			[Address(RVA = "0x1AF83B0", Offset = "0x1AF6FB0", VA = "0x181AF83B0")]
			set
			{
			}
		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0x1AF8130", Offset = "0x1AF6D30", VA = "0x181AF8130")]
		private void Start()
		{
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0x1AF82A0", Offset = "0x1AF6EA0", VA = "0x181AF82A0")]
		public PrefabInstHolder()
		{
		}

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The target the prefab would be instantiated into")]
		private Transform _prefabContainer;

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_instance;

		// Token: 0x0400210E RID: 8462
		[Token(Token = "0x400210E")]
		[FieldOffset(Offset = "0x30")]
		private Action<GameObject> m_onAchieveInstOnce;

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prefabContainer;

		// Token: 0x04002110 RID: 8464
		[Token(Token = "0x4002110")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_achieveInst;

		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
