using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B47 RID: 23367
	[Token(Token = "0x2005B47")]
	public class ShopKeeperGraphic : MonoBehaviour
	{
		// Token: 0x06021ED6 RID: 138966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ED6")]
		[Address(RVA = "0x1C63940", Offset = "0x1C62540", VA = "0x181C63940")]
		public void OnInteract()
		{
		}

		// Token: 0x06021ED7 RID: 138967 RVA: 0x000BBC50 File Offset: 0x000B9E50
		[Token(Token = "0x6021ED7")]
		[Address(RVA = "0x1C63D30", Offset = "0x1C62930", VA = "0x181C63D30")]
		private bool _SetAnimation(string animKey, bool loop)
		{
			return default(bool);
		}

		// Token: 0x06021ED8 RID: 138968 RVA: 0x000BBC68 File Offset: 0x000B9E68
		[Token(Token = "0x6021ED8")]
		[Address(RVA = "0x1C63BD0", Offset = "0x1C627D0", VA = "0x181C63BD0")]
		private bool _AddAnimation(string animKey, bool loop)
		{
			return default(bool);
		}

		// Token: 0x06021ED9 RID: 138969 RVA: 0x000BBC80 File Offset: 0x000B9E80
		[Token(Token = "0x6021ED9")]
		[Address(RVA = "0x1C63C00", Offset = "0x1C62800", VA = "0x181C63C00")]
		private bool _PlayAnimation(string animKey, bool loop, bool isAdd, out float time)
		{
			return default(bool);
		}

		// Token: 0x06021EDA RID: 138970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EDA")]
		[Address(RVA = "0x1C63990", Offset = "0x1C62590", VA = "0x181C63990")]
		private void Start()
		{
		}

		// Token: 0x06021EDB RID: 138971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EDB")]
		[Address(RVA = "0x1C63B50", Offset = "0x1C62750", VA = "0x181C63B50")]
		private void Update()
		{
		}

		// Token: 0x06021EDC RID: 138972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EDC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopKeeperGraphic()
		{
		}

		// Token: 0x0402E7B5 RID: 190389
		[Token(Token = "0x402E7B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkeletonGraphic _graphic;

		// Token: 0x0402E7B6 RID: 190390
		[Token(Token = "0x402E7B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopKeeperGraphic.Options _options;

		// Token: 0x0402E7B7 RID: 190391
		[Token(Token = "0x402E7B7")]
		[FieldOffset(Offset = "0x28")]
		private StateMachine m_stateMachine;

		// Token: 0x02005B48 RID: 23368
		[Token(Token = "0x2005B48")]
		[Serializable]
		public class Options : StateMachine.DefaultBlackboard
		{
			// Token: 0x06021EDD RID: 138973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021EDD")]
			[Address(RVA = "0x1C587B0", Offset = "0x1C573B0", VA = "0x181C587B0")]
			public Options()
			{
			}

			// Token: 0x0402E7B8 RID: 190392
			[Token(Token = "0x402E7B8")]
			[FieldOffset(Offset = "0x10")]
			public string startAnim;

			// Token: 0x0402E7B9 RID: 190393
			[Token(Token = "0x402E7B9")]
			[FieldOffset(Offset = "0x18")]
			public string idleAnim;

			// Token: 0x0402E7BA RID: 190394
			[Token(Token = "0x402E7BA")]
			[FieldOffset(Offset = "0x20")]
			public string interactAnim;
		}

		// Token: 0x02005B49 RID: 23369
		[Token(Token = "0x2005B49")]
		public static class States
		{
			// Token: 0x06021EDE RID: 138974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021EDE")]
			[Address(RVA = "0x1C6C7A0", Offset = "0x1C6B3A0", VA = "0x181C6C7A0")]
			public static StateMachine ConstructStateMachine(ShopKeeperGraphic holder)
			{
				return null;
			}

			// Token: 0x02005B4A RID: 23370
			[Token(Token = "0x2005B4A")]
			public enum State
			{
				// Token: 0x0402E7BC RID: 190396
				[Token(Token = "0x402E7BC")]
				DEFAULT,
				// Token: 0x0402E7BD RID: 190397
				[Token(Token = "0x402E7BD")]
				BORN,
				// Token: 0x0402E7BE RID: 190398
				[Token(Token = "0x402E7BE")]
				IDLE,
				// Token: 0x0402E7BF RID: 190399
				[Token(Token = "0x402E7BF")]
				INTERACT,
				// Token: 0x0402E7C0 RID: 190400
				[Token(Token = "0x402E7C0")]
				TERMINAL = -1
			}

			// Token: 0x02005B4B RID: 23371
			[Token(Token = "0x2005B4B")]
			private class BornState : HierachyStateMachine<ShopKeeperGraphic.States.State, ShopKeeperGraphic, ShopKeeperGraphic.Options>.StateNode
			{
				// Token: 0x06021EDF RID: 138975 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EDF")]
				[Address(RVA = "0x1C584A0", Offset = "0x1C570A0", VA = "0x181C584A0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06021EE0 RID: 138976 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE0")]
				[Address(RVA = "0x1C58560", Offset = "0x1C57160", VA = "0x181C58560", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x06021EE1 RID: 138977 RVA: 0x000BBC98 File Offset: 0x000B9E98
				[Token(Token = "0x6021EE1")]
				[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x06021EE2 RID: 138978 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE2")]
				[Address(RVA = "0x1C58610", Offset = "0x1C57210", VA = "0x181C58610")]
				public BornState()
				{
				}

				// Token: 0x0402E7C1 RID: 190401
				[Token(Token = "0x402E7C1")]
				[FieldOffset(Offset = "0x18")]
				private float m_time;
			}

			// Token: 0x02005B4C RID: 23372
			[Token(Token = "0x2005B4C")]
			private class IdleState : HierachyStateMachine<ShopKeeperGraphic.States.State, ShopKeeperGraphic, ShopKeeperGraphic.Options>.StateNode
			{
				// Token: 0x06021EE3 RID: 138979 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE3")]
				[Address(RVA = "0x1C6F260", Offset = "0x1C6DE60", VA = "0x181C6F260", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06021EE4 RID: 138980 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE4")]
				[Address(RVA = "0x1C6F310", Offset = "0x1C6DF10", VA = "0x181C6F310")]
				public IdleState()
				{
				}
			}

			// Token: 0x02005B4D RID: 23373
			[Token(Token = "0x2005B4D")]
			private class InteractState : HierachyStateMachine<ShopKeeperGraphic.States.State, ShopKeeperGraphic, ShopKeeperGraphic.Options>.StateNode
			{
				// Token: 0x06021EE5 RID: 138981 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE5")]
				[Address(RVA = "0x1C6F350", Offset = "0x1C6DF50", VA = "0x181C6F350", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x06021EE6 RID: 138982 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE6")]
				[Address(RVA = "0x1C6F410", Offset = "0x1C6E010", VA = "0x181C6F410", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x06021EE7 RID: 138983 RVA: 0x000BBCB0 File Offset: 0x000B9EB0
				[Token(Token = "0x6021EE7")]
				[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x06021EE8 RID: 138984 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021EE8")]
				[Address(RVA = "0x1C6F4C0", Offset = "0x1C6E0C0", VA = "0x181C6F4C0")]
				public InteractState()
				{
				}

				// Token: 0x0402E7C2 RID: 190402
				[Token(Token = "0x402E7C2")]
				[FieldOffset(Offset = "0x18")]
				private float m_time;
			}
		}
	}
}
