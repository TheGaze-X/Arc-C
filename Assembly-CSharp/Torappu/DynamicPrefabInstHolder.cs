using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200054D RID: 1357
	[Token(Token = "0x200054D")]
	[DisallowMultipleComponent]
	public abstract class DynamicPrefabInstHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06005AA1 RID: 23201
		[Token(Token = "0x6005AA1")]
		public abstract GameObject GetPrefab();

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C96")]
		protected Transform prefabContainer
		{
			[Token(Token = "0x6005AA2")]
			[Address(RVA = "0x1AEDB50", Offset = "0x1AEC750", VA = "0x181AEDB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C97")]
		public Action<GameObject> achieveInst
		{
			[Token(Token = "0x6005AA3")]
			[Address(RVA = "0x1AEDC00", Offset = "0x1AEC800", VA = "0x181AEDC00")]
			set
			{
			}
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x1AED930", Offset = "0x1AEC530", VA = "0x181AED930")]
		private void Start()
		{
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x1AEDAF0", Offset = "0x1AEC6F0", VA = "0x181AEDAF0")]
		protected DynamicPrefabInstHolder()
		{
		}

		// Token: 0x0400205D RID: 8285
		[Token(Token = "0x400205D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The target the prefab would be instantiated into")]
		private Transform _prefabContainer;

		// Token: 0x0400205E RID: 8286
		[Token(Token = "0x400205E")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_instance;

		// Token: 0x0400205F RID: 8287
		[Token(Token = "0x400205F")]
		[FieldOffset(Offset = "0x28")]
		private Action<GameObject> m_onAchieveInstOnce;

		// Token: 0x04002060 RID: 8288
		[Token(Token = "0x4002060")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prefabContainer;

		// Token: 0x04002061 RID: 8289
		[Token(Token = "0x4002061")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_achieveInst;

		// Token: 0x04002062 RID: 8290
		[Token(Token = "0x4002062")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
