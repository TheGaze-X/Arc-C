using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#multiplayer-uis")]
	public class MultiplayerEventSystem : EventSystem
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037B")]
		public GameObject playerRoot
		{
			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x56C5CD0", Offset = "0x56C48D0", VA = "0x1856C5CD0")]
			set
			{
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x56C5B90", Offset = "0x56C4790", VA = "0x1856C5B90", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x56C5B80", Offset = "0x56C4780", VA = "0x1856C5B80", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x56C5AC0", Offset = "0x56C46C0", VA = "0x1856C5AC0")]
		private void InitializePlayerRoot()
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x56C5BB0", Offset = "0x56C47B0", VA = "0x1856C5BB0", Slot = "18")]
		protected override void Update()
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x56C5C80", Offset = "0x56C4880", VA = "0x1856C5C80")]
		public MultiplayerEventSystem()
		{
		}

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
		private GameObject m_PlayerRoot;
	}
}
