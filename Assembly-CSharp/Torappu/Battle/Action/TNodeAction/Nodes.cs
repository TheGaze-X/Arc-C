using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using XNode;

namespace Torappu.Battle.Action.TNodeAction
{
	// Token: 0x020031E7 RID: 12775
	[Token(Token = "0x20031E7")]
	public static class Nodes
	{
		// Token: 0x020031E8 RID: 12776
		[Token(Token = "0x20031E8")]
		[ActionInfo(Category = "TNode")]
		public class OnEvent : TNodeBase
		{
			// Token: 0x17002FF4 RID: 12276
			// (get) Token: 0x0601446D RID: 83053 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601446E RID: 83054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FF4")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x601446D")]
				[Address(RVA = "0xC91710", Offset = "0xC90310", VA = "0x180C91710", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x601446E")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x0601446F RID: 83055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601446F")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public OnEvent()
			{
			}

			// Token: 0x020031E9 RID: 12777
			[Token(Token = "0x20031E9")]
			[Serializable]
			public class OnEventTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x17002FF5 RID: 12277
				// (get) Token: 0x06014470 RID: 83056 RVA: 0x000864D8 File Offset: 0x000846D8
				[Token(Token = "0x17002FF5")]
				public Buff.Event eventType
				{
					[Token(Token = "0x6014470")]
					[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
					get
					{
						return Buff.Event.ON_BUFF_START;
					}
				}

				// Token: 0x06014471 RID: 83057 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014471")]
				[Address(RVA = "0xC91600", Offset = "0xC90200", VA = "0x180C91600", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x06014472 RID: 83058 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014472")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public OnEventTNodeData()
				{
				}

				// Token: 0x04017EC5 RID: 97989
				[Token(Token = "0x4017EC5")]
				[FieldOffset(Offset = "0x30")]
				[SerializeField]
				private Buff.Event _eventType;
			}
		}

		// Token: 0x020031EA RID: 12778
		[Token(Token = "0x20031EA")]
		[ActionInfo(Category = "TNode")]
		public class IfElse : TNodeBase
		{
			// Token: 0x17002FF6 RID: 12278
			// (get) Token: 0x06014473 RID: 83059 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014474 RID: 83060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FF6")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x6014473")]
				[Address(RVA = "0xC90230", Offset = "0xC8EE30", VA = "0x180C90230", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x6014474")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x06014475 RID: 83061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014475")]
			[Address(RVA = "0xC90170", Offset = "0xC8ED70", VA = "0x180C90170", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x06014476 RID: 83062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014476")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public IfElse()
			{
			}

			// Token: 0x04017EC6 RID: 97990
			[Token(Token = "0x4017EC6")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase onSuccess;

			// Token: 0x04017EC7 RID: 97991
			[Token(Token = "0x4017EC7")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase onFail;

			// Token: 0x020031EB RID: 12779
			[Token(Token = "0x20031EB")]
			[Serializable]
			public class IfElseTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x06014477 RID: 83063 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014477")]
				[Address(RVA = "0xC8FD00", Offset = "0xC8E900", VA = "0x180C8FD00", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x06014478 RID: 83064 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014478")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public IfElseTNodeData()
				{
				}
			}
		}

		// Token: 0x020031EC RID: 12780
		[Token(Token = "0x20031EC")]
		[ActionInfo(Category = "TNode")]
		public class RandomAction : TNodeBase
		{
			// Token: 0x17002FF7 RID: 12279
			// (get) Token: 0x06014479 RID: 83065 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601447A RID: 83066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FF7")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x6014479")]
				[Address(RVA = "0xC91DE0", Offset = "0xC909E0", VA = "0x180C91DE0", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x601447A")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x0601447B RID: 83067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601447B")]
			[Address(RVA = "0xC91D20", Offset = "0xC90920", VA = "0x180C91D20", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x0601447C RID: 83068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601447C")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public RandomAction()
			{
			}

			// Token: 0x04017EC8 RID: 97992
			[Token(Token = "0x4017EC8")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase actions;

			// Token: 0x04017EC9 RID: 97993
			[Token(Token = "0x4017EC9")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase otherwiseActions;

			// Token: 0x020031ED RID: 12781
			[Token(Token = "0x20031ED")]
			[Serializable]
			public class RandomActionTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x0601447D RID: 83069 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601447D")]
				[Address(RVA = "0xC91930", Offset = "0xC90530", VA = "0x180C91930", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x0601447E RID: 83070 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601447E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RandomActionTNodeData()
				{
				}
			}
		}

		// Token: 0x020031EE RID: 12782
		[Token(Token = "0x20031EE")]
		[ActionInfo(Category = "TNode")]
		public class Loop : TNodeBase
		{
			// Token: 0x17002FF8 RID: 12280
			// (get) Token: 0x0601447F RID: 83071 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014480 RID: 83072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FF8")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x601447F")]
				[Address(RVA = "0xC91310", Offset = "0xC8FF10", VA = "0x180C91310", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x6014480")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x06014481 RID: 83073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014481")]
			[Address(RVA = "0xC91250", Offset = "0xC8FE50", VA = "0x180C91250", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x06014482 RID: 83074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014482")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public Loop()
			{
			}

			// Token: 0x04017ECA RID: 97994
			[Token(Token = "0x4017ECA")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase loopBody;

			// Token: 0x020031EF RID: 12783
			[Token(Token = "0x20031EF")]
			[Serializable]
			public class LoopTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x06014483 RID: 83075 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014483")]
				[Address(RVA = "0xC90F20", Offset = "0xC8FB20", VA = "0x180C90F20", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x06014484 RID: 83076 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014484")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public LoopTNodeData()
				{
				}
			}
		}

		// Token: 0x020031F0 RID: 12784
		[Token(Token = "0x20031F0")]
		[ActionInfo(Category = "TNode")]
		public class AlwaysExecuteNodeList : TNodeBase
		{
			// Token: 0x17002FF9 RID: 12281
			// (get) Token: 0x06014485 RID: 83077 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014486 RID: 83078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FF9")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x6014485")]
				[Address(RVA = "0xC842C0", Offset = "0xC82EC0", VA = "0x180C842C0", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x6014486")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x06014487 RID: 83079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014487")]
			[Address(RVA = "0xC841F0", Offset = "0xC82DF0", VA = "0x180C841F0", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x06014488 RID: 83080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014488")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public AlwaysExecuteNodeList()
			{
			}

			// Token: 0x04017ECB RID: 97995
			[Token(Token = "0x4017ECB")]
			private const int MAX_NODE_COUNT = 8;

			// Token: 0x04017ECC RID: 97996
			[Token(Token = "0x4017ECC")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node1;

			// Token: 0x04017ECD RID: 97997
			[Token(Token = "0x4017ECD")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node2;

			// Token: 0x04017ECE RID: 97998
			[Token(Token = "0x4017ECE")]
			[FieldOffset(Offset = "0x70")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node3;

			// Token: 0x04017ECF RID: 97999
			[Token(Token = "0x4017ECF")]
			[FieldOffset(Offset = "0x78")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node4;

			// Token: 0x04017ED0 RID: 98000
			[Token(Token = "0x4017ED0")]
			[FieldOffset(Offset = "0x80")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node5;

			// Token: 0x04017ED1 RID: 98001
			[Token(Token = "0x4017ED1")]
			[FieldOffset(Offset = "0x88")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node6;

			// Token: 0x04017ED2 RID: 98002
			[Token(Token = "0x4017ED2")]
			[FieldOffset(Offset = "0x90")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node7;

			// Token: 0x04017ED3 RID: 98003
			[Token(Token = "0x4017ED3")]
			[FieldOffset(Offset = "0x98")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase _node8;

			// Token: 0x020031F1 RID: 12785
			[Token(Token = "0x20031F1")]
			[Serializable]
			public class AlwaysExecuteNodeListTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x06014489 RID: 83081 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014489")]
				[Address(RVA = "0xC83D50", Offset = "0xC82950", VA = "0x180C83D50", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x0601448A RID: 83082 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601448A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public AlwaysExecuteNodeListTNodeData()
				{
				}

				// Token: 0x04017ED4 RID: 98004
				[Token(Token = "0x4017ED4")]
				[FieldOffset(Offset = "0x0")]
				private static StringBuilder s_builder;
			}
		}

		// Token: 0x020031F2 RID: 12786
		[Token(Token = "0x20031F2")]
		[ActionInfo(Category = "TNode")]
		public class IfConditions : TNodeBase
		{
			// Token: 0x17002FFA RID: 12282
			// (get) Token: 0x0601448C RID: 83084 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601448D RID: 83085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FFA")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x601448C")]
				[Address(RVA = "0xC8FC80", Offset = "0xC8E880", VA = "0x180C8FC80", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x601448D")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x0601448E RID: 83086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601448E")]
			[Address(RVA = "0xC8FBC0", Offset = "0xC8E7C0", VA = "0x180C8FBC0", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x0601448F RID: 83087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601448F")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public IfConditions()
			{
			}

			// Token: 0x04017ED5 RID: 98005
			[Token(Token = "0x4017ED5")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase onSuccess;

			// Token: 0x04017ED6 RID: 98006
			[Token(Token = "0x4017ED6")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase onFail;

			// Token: 0x020031F3 RID: 12787
			[Token(Token = "0x20031F3")]
			[Serializable]
			public class IfConditionsTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x06014490 RID: 83088 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014490")]
				[Address(RVA = "0xC8F7D0", Offset = "0xC8E3D0", VA = "0x180C8F7D0", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x06014491 RID: 83089 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014491")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public IfConditionsTNodeData()
				{
				}
			}
		}

		// Token: 0x020031F4 RID: 12788
		[Token(Token = "0x20031F4")]
		[ActionInfo(Category = "Switch")]
		public class SwitchDirection : TNodeBase
		{
			// Token: 0x17002FFB RID: 12283
			// (get) Token: 0x06014492 RID: 83090 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014493 RID: 83091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FFB")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x6014492")]
				[Address(RVA = "0xC95B70", Offset = "0xC94770", VA = "0x180C95B70", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x6014493")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x06014494 RID: 83092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014494")]
			[Address(RVA = "0xC95AB0", Offset = "0xC946B0", VA = "0x180C95AB0", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x06014495 RID: 83093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014495")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public SwitchDirection()
			{
			}

			// Token: 0x04017ED7 RID: 98007
			[Token(Token = "0x4017ED7")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase rightNodes;

			// Token: 0x04017ED8 RID: 98008
			[Token(Token = "0x4017ED8")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase leftNodes;

			// Token: 0x04017ED9 RID: 98009
			[Token(Token = "0x4017ED9")]
			[FieldOffset(Offset = "0x70")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase upNodes;

			// Token: 0x04017EDA RID: 98010
			[Token(Token = "0x4017EDA")]
			[FieldOffset(Offset = "0x78")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase downNodes;

			// Token: 0x020031F5 RID: 12789
			[Token(Token = "0x20031F5")]
			[Serializable]
			private class SwitchDirectionTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x06014496 RID: 83094 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014496")]
				[Address(RVA = "0xC954F0", Offset = "0xC940F0", VA = "0x180C954F0", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x06014497 RID: 83095 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6014497")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SwitchDirectionTNodeData()
				{
				}
			}
		}

		// Token: 0x020031F6 RID: 12790
		[Token(Token = "0x20031F6")]
		[ActionInfo(Category = "Switch")]
		public class SwitchSourceDirection : TNodeBase
		{
			// Token: 0x17002FFC RID: 12284
			// (get) Token: 0x06014498 RID: 83096 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014499 RID: 83097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FFC")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x6014498")]
				[Address(RVA = "0xC96A30", Offset = "0xC95630", VA = "0x180C96A30", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x6014499")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x0601449A RID: 83098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601449A")]
			[Address(RVA = "0xC96970", Offset = "0xC95570", VA = "0x180C96970", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x0601449B RID: 83099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601449B")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public SwitchSourceDirection()
			{
			}

			// Token: 0x04017EDB RID: 98011
			[Token(Token = "0x4017EDB")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase rightNodes;

			// Token: 0x04017EDC RID: 98012
			[Token(Token = "0x4017EDC")]
			[FieldOffset(Offset = "0x68")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase leftNodes;

			// Token: 0x04017EDD RID: 98013
			[Token(Token = "0x4017EDD")]
			[FieldOffset(Offset = "0x70")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase upNodes;

			// Token: 0x04017EDE RID: 98014
			[Token(Token = "0x4017EDE")]
			[FieldOffset(Offset = "0x78")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase downNodes;

			// Token: 0x020031F7 RID: 12791
			[Token(Token = "0x20031F7")]
			[Serializable]
			private class SwitchSourceDirectionTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x0601449C RID: 83100 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601449C")]
				[Address(RVA = "0xC963B0", Offset = "0xC94FB0", VA = "0x180C963B0", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x0601449D RID: 83101 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601449D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SwitchSourceDirectionTNodeData()
				{
				}
			}
		}

		// Token: 0x020031F8 RID: 12792
		[Token(Token = "0x20031F8")]
		[ActionInfo(Category = "TNode")]
		public class CheckCanTriggerLikeAttack : TNodeBase
		{
			// Token: 0x17002FFD RID: 12285
			// (get) Token: 0x0601449E RID: 83102 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601449F RID: 83103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FFD")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x601449E")]
				[Address(RVA = "0xC87520", Offset = "0xC86120", VA = "0x180C87520", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x601449F")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x060144A0 RID: 83104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60144A0")]
			[Address(RVA = "0xC87460", Offset = "0xC86060", VA = "0x180C87460", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x060144A1 RID: 83105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144A1")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public CheckCanTriggerLikeAttack()
			{
			}

			// Token: 0x04017EDF RID: 98015
			[Token(Token = "0x4017EDF")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase attackTriggerNodes;

			// Token: 0x020031F9 RID: 12793
			[Token(Token = "0x20031F9")]
			[Serializable]
			public class CheckCanTriggerLikeAttackTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x060144A2 RID: 83106 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60144A2")]
				[Address(RVA = "0xC87170", Offset = "0xC85D70", VA = "0x180C87170", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x060144A3 RID: 83107 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60144A3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CheckCanTriggerLikeAttackTNodeData()
				{
				}
			}
		}

		// Token: 0x020031FA RID: 12794
		[Token(Token = "0x20031FA")]
		[ActionInfo(Category = "TNode")]
		public class RunActionsToWdslmAbilityTarget : TNodeBase
		{
			// Token: 0x17002FFE RID: 12286
			// (get) Token: 0x060144A4 RID: 83108 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060144A5 RID: 83109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002FFE")]
			public override TNodeBase.TNodeBaseData Data
			{
				[Token(Token = "0x60144A4")]
				[Address(RVA = "0xC937D0", Offset = "0xC923D0", VA = "0x180C937D0", Slot = "9")]
				get
				{
					return null;
				}
				[Token(Token = "0x60144A5")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x060144A6 RID: 83110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60144A6")]
			[Address(RVA = "0xC93710", Offset = "0xC92310", VA = "0x180C93710", Slot = "12")]
			public override TNodeBase.TNodeBaseData SerializeData()
			{
				return null;
			}

			// Token: 0x060144A7 RID: 83111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144A7")]
			[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
			public RunActionsToWdslmAbilityTarget()
			{
			}

			// Token: 0x04017EE0 RID: 98016
			[Token(Token = "0x4017EE0")]
			[FieldOffset(Offset = "0x60")]
			[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
			public TNodeBase actionsToTargets;

			// Token: 0x020031FB RID: 12795
			[Token(Token = "0x20031FB")]
			[Serializable]
			public class RunActionsToWdslmAbilityTargetTNodeData : TNodeBase.TNodeBaseData
			{
				// Token: 0x060144A8 RID: 83112 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60144A8")]
				[Address(RVA = "0xC93420", Offset = "0xC92020", VA = "0x180C93420", Slot = "6")]
				public override void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
				{
				}

				// Token: 0x060144A9 RID: 83113 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60144A9")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RunActionsToWdslmAbilityTargetTNodeData()
				{
				}
			}
		}
	}
}
