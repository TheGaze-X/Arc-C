using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200367E RID: 13950
	[Token(Token = "0x200367E")]
	[CreateAssetMenu(menuName = "Torappu/UI/DynSateHub")]
	[Serializable]
	public class UIDynStateHub : ScriptableObject, ISerializationCallbackReceiver, IHotfixable
	{
		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0601632B RID: 90923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601632C RID: 90924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700355A")]
		[Inspect]
		private State[] _dragStatesHere
		{
			[Token(Token = "0x601632B")]
			[Address(RVA = "0xEA3BC0", Offset = "0xEA27C0", VA = "0x180EA3BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x601632C")]
			[Address(RVA = "0xEA3C30", Offset = "0xEA2830", VA = "0x180EA3C30")]
			set
			{
			}
		}

		// Token: 0x0601632D RID: 90925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601632D")]
		[Address(RVA = "0xEA3A00", Offset = "0xEA2600", VA = "0x180EA3A00")]
		private void _InitIfNotRuntime()
		{
		}

		// Token: 0x0601632E RID: 90926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601632E")]
		[Address(RVA = "0xEA3500", Offset = "0xEA2100", VA = "0x180EA3500")]
		public string GetStateResPath(DynStateID id)
		{
			return null;
		}

		// Token: 0x0601632F RID: 90927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601632F")]
		[Address(RVA = "0xEA3780", Offset = "0xEA2380", VA = "0x180EA3780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06016330 RID: 90928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016330")]
		[Address(RVA = "0xEA3720", Offset = "0xEA2320", VA = "0x180EA3720", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06016331 RID: 90929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016331")]
		[Address(RVA = "0xEA3B60", Offset = "0xEA2760", VA = "0x180EA3B60")]
		public UIDynStateHub()
		{
		}

		// Token: 0x0401AAD9 RID: 109273
		[Token(Token = "0x401AAD9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Add new DynStateID if new states are added")]
		private List<UIDynStateHub.StateUrl> _states;

		// Token: 0x0401AADA RID: 109274
		[Token(Token = "0x401AADA")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<DynStateID, UIDynStateHub.StateUrl> m_stateMapRuntime;

		// Token: 0x0401AADB RID: 109275
		[Token(Token = "0x401AADB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__dragStatesHere;

		// Token: 0x0401AADC RID: 109276
		[Token(Token = "0x401AADC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set__dragStatesHere;

		// Token: 0x0401AADD RID: 109277
		[Token(Token = "0x401AADD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNotRuntime;

		// Token: 0x0401AADE RID: 109278
		[Token(Token = "0x401AADE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStateResPath;

		// Token: 0x0401AADF RID: 109279
		[Token(Token = "0x401AADF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBeforeSerialize;

		// Token: 0x0401AAE0 RID: 109280
		[Token(Token = "0x401AAE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAfterDeserialize;

		// Token: 0x0401AAE1 RID: 109281
		[Token(Token = "0x401AAE1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200367F RID: 13951
		[Token(Token = "0x200367F")]
		[Serializable]
		public struct StateUrl
		{
			// Token: 0x0401AAE2 RID: 109282
			[Token(Token = "0x401AAE2")]
			[FieldOffset(Offset = "0x0")]
			public DynStateID id;

			// Token: 0x0401AAE3 RID: 109283
			[Token(Token = "0x401AAE3")]
			[FieldOffset(Offset = "0x8")]
			public string resPath;
		}
	}
}
