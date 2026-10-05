using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001166 RID: 4454
	[Token(Token = "0x2001166")]
	public class RoguelikeDungeonNode
	{
		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x000325B0 File Offset: 0x000307B0
		[Token(Token = "0x17000D34")]
		public bool isPassed
		{
			[Token(Token = "0x6006F43")]
			[Address(RVA = "0x2111500", Offset = "0x2110100", VA = "0x182111500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06006F44 RID: 28484 RVA: 0x000325C8 File Offset: 0x000307C8
		[Token(Token = "0x17000D35")]
		public bool isSpecialZoneNode
		{
			[Token(Token = "0x6006F44")]
			[Address(RVA = "0x2111520", Offset = "0x2110120", VA = "0x182111520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F45")]
		public T CheckPlugin<T>() where T : RoguelikeDungeonNode.SpecialZonePlugin
		{
			return null;
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F46")]
		[Address(RVA = "0x21112D0", Offset = "0x210FED0", VA = "0x1821112D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F47")]
		[Address(RVA = "0x21111E0", Offset = "0x210FDE0", VA = "0x1821111E0")]
		public string GetNodeTypeString()
		{
			return null;
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x000325E0 File Offset: 0x000307E0
		[Token(Token = "0x6006F48")]
		[Address(RVA = "0x2111280", Offset = "0x210FE80", VA = "0x182111280")]
		public RoguelikeSpZoneNodeType GetSpZoneNodeType()
		{
			return RoguelikeSpZoneNodeType.NORMAL;
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F49")]
		[Address(RVA = "0x21112E0", Offset = "0x210FEE0", VA = "0x1821112E0")]
		public RoguelikeDungeonNode()
		{
		}

		// Token: 0x04005F5E RID: 24414
		[Token(Token = "0x4005F5E")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04005F5F RID: 24415
		[Token(Token = "0x4005F5F")]
		[FieldOffset(Offset = "0x14")]
		public int depth;

		// Token: 0x04005F60 RID: 24416
		[Token(Token = "0x4005F60")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x04005F61 RID: 24417
		[Token(Token = "0x4005F61")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeEventType type;

		// Token: 0x04005F62 RID: 24418
		[Token(Token = "0x4005F62")]
		[FieldOffset(Offset = "0x20")]
		public int nodeDisplaySubType;

		// Token: 0x04005F63 RID: 24419
		[Token(Token = "0x4005F63")]
		[FieldOffset(Offset = "0x28")]
		public long fts;

		// Token: 0x04005F64 RID: 24420
		[Token(Token = "0x4005F64")]
		[FieldOffset(Offset = "0x30")]
		public bool canReach;

		// Token: 0x04005F65 RID: 24421
		[Token(Token = "0x4005F65")]
		[FieldOffset(Offset = "0x31")]
		public bool isNextStep;

		// Token: 0x04005F66 RID: 24422
		[Token(Token = "0x4005F66")]
		[FieldOffset(Offset = "0x32")]
		public bool isNextLocked;

		// Token: 0x04005F67 RID: 24423
		[Token(Token = "0x4005F67")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeDungeonLine> parents;

		// Token: 0x04005F68 RID: 24424
		[Token(Token = "0x4005F68")]
		[FieldOffset(Offset = "0x40")]
		public List<RoguelikeDungeonLine> children;

		// Token: 0x04005F69 RID: 24425
		[Token(Token = "0x4005F69")]
		[FieldOffset(Offset = "0x48")]
		public List<RoguelikeDungeonLine> brother;

		// Token: 0x04005F6A RID: 24426
		[Token(Token = "0x4005F6A")]
		[FieldOffset(Offset = "0x50")]
		public List<string> attach;

		// Token: 0x04005F6B RID: 24427
		[Token(Token = "0x4005F6B")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeShop shop;

		// Token: 0x04005F6C RID: 24428
		[Token(Token = "0x4005F6C")]
		[FieldOffset(Offset = "0x60")]
		public List<PlayerRoguelikePendingEvent.SceneContent> scenes;

		// Token: 0x04005F6D RID: 24429
		[Token(Token = "0x4005F6D")]
		[FieldOffset(Offset = "0x68")]
		public PlayerRoguelikePendingEvent.BattleContent battle;

		// Token: 0x04005F6E RID: 24430
		[Token(Token = "0x4005F6E")]
		[FieldOffset(Offset = "0x70")]
		public string stageId;

		// Token: 0x04005F6F RID: 24431
		[Token(Token = "0x4005F6F")]
		[FieldOffset(Offset = "0x78")]
		public string topicId;

		// Token: 0x04005F70 RID: 24432
		[Token(Token = "0x4005F70")]
		[FieldOffset(Offset = "0x80")]
		public bool isDiscard;

		// Token: 0x04005F71 RID: 24433
		[Token(Token = "0x4005F71")]
		[FieldOffset(Offset = "0x81")]
		public bool isFutureNode;

		// Token: 0x04005F72 RID: 24434
		[Token(Token = "0x4005F72")]
		[FieldOffset(Offset = "0x82")]
		public bool isInTrace;

		// Token: 0x04005F73 RID: 24435
		[Token(Token = "0x4005F73")]
		[FieldOffset(Offset = "0x83")]
		public bool isCurrent;

		// Token: 0x04005F74 RID: 24436
		[Token(Token = "0x4005F74")]
		[FieldOffset(Offset = "0x84")]
		public bool isInDiffDisplayZone;

		// Token: 0x04005F75 RID: 24437
		[Token(Token = "0x4005F75")]
		[FieldOffset(Offset = "0x88")]
		public PlayerNodeDetailContent detailContent;

		// Token: 0x04005F76 RID: 24438
		[Token(Token = "0x4005F76")]
		[FieldOffset(Offset = "0x90")]
		public PlayerNodeForesightType foresightType;

		// Token: 0x04005F77 RID: 24439
		[Token(Token = "0x4005F77")]
		[FieldOffset(Offset = "0x98")]
		public PlayerNodeRollInfo rollInfo;

		// Token: 0x04005F78 RID: 24440
		[Token(Token = "0x4005F78")]
		[FieldOffset(Offset = "0xA0")]
		public string instId;

		// Token: 0x04005F79 RID: 24441
		[Token(Token = "0x4005F79")]
		[FieldOffset(Offset = "0xA8")]
		public RoguelikeDungeonNode.SpecialZonePlugin spPlugin;

		// Token: 0x02001167 RID: 4455
		[Token(Token = "0x2001167")]
		public abstract class SpecialZonePlugin
		{
			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x06006F4A RID: 28490 RVA: 0x000325F8 File Offset: 0x000307F8
			[Token(Token = "0x17000D36")]
			public virtual bool isBattleNode
			{
				[Token(Token = "0x6006F4A")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x06006F4B RID: 28491 RVA: 0x00032610 File Offset: 0x00030810
			[Token(Token = "0x17000D37")]
			public virtual bool isChoiceNode
			{
				[Token(Token = "0x6006F4B")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x06006F4C RID: 28492 RVA: 0x00032628 File Offset: 0x00030828
			[Token(Token = "0x17000D38")]
			public virtual bool isShopNode
			{
				[Token(Token = "0x6006F4C")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x06006F4D RID: 28493 RVA: 0x00032640 File Offset: 0x00030840
			[Token(Token = "0x17000D39")]
			public virtual bool isAlchemyNode
			{
				[Token(Token = "0x6006F4D")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006F4E RID: 28494
			[Token(Token = "0x6006F4E")]
			public abstract bool CanMoveToDirectly();

			// Token: 0x06006F4F RID: 28495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F4F")]
			[Address(RVA = "0x2116440", Offset = "0x2115040", VA = "0x182116440", Slot = "9")]
			public virtual void CheckIfMoveTo(Action onMoveTo)
			{
			}

			// Token: 0x06006F50 RID: 28496
			[Token(Token = "0x6006F50")]
			public abstract string GetNodeTypeString();

			// Token: 0x06006F51 RID: 28497
			[Token(Token = "0x6006F51")]
			public abstract RoguelikeSpZoneNodeType GetSpZoneNodeType();

			// Token: 0x06006F52 RID: 28498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F52")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected SpecialZonePlugin()
			{
			}
		}
	}
}
