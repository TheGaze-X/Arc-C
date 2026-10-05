using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XNode;

namespace Torappu.Battle.Action.TNodeAction
{
	// Token: 0x020031FD RID: 12797
	[Token(Token = "0x20031FD")]
	[Node.CreateNodeMenuAttribute(null)]
	[NodeBlockWidth(4)]
	public class TNodeBase : Node
	{
		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x060144AC RID: 83116 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060144AD RID: 83117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002FFF")]
		public ActionNode Action
		{
			[Token(Token = "0x60144AC")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60144AD")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x060144AE RID: 83118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060144AF RID: 83119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003000")]
		public virtual TNodeBase.TNodeBaseData Data
		{
			[Token(Token = "0x60144AE")]
			[Address(RVA = "0xC97BA0", Offset = "0xC967A0", VA = "0x180C97BA0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60144AF")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x060144B0 RID: 83120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060144B1 RID: 83121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003001")]
		public string ID
		{
			[Token(Token = "0x60144B0")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60144B1")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x060144B2 RID: 83122 RVA: 0x000864F0 File Offset: 0x000846F0
		// (set) Token: 0x060144B3 RID: 83123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003002")]
		public bool guiInited
		{
			[Token(Token = "0x60144B2")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60144B3")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060144B4 RID: 83124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144B4")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "11")]
		public virtual ActionNode SerializeAction()
		{
			return null;
		}

		// Token: 0x060144B5 RID: 83125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144B5")]
		[Address(RVA = "0xC979A0", Offset = "0xC965A0", VA = "0x180C979A0", Slot = "12")]
		public virtual TNodeBase.TNodeBaseData SerializeData()
		{
			return null;
		}

		// Token: 0x060144B6 RID: 83126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144B6")]
		[Address(RVA = "0xC97460", Offset = "0xC96060", VA = "0x180C97460", Slot = "5")]
		protected override void Init()
		{
		}

		// Token: 0x060144B7 RID: 83127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144B7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override object GetValue(NodePort port)
		{
			return null;
		}

		// Token: 0x060144B8 RID: 83128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60144B8")]
		[Address(RVA = "0xC972C0", Offset = "0xC95EC0", VA = "0x180C972C0")]
		public static Type GetTNodeType(TNodeBase.TNodeBaseData nodeData)
		{
			return null;
		}

		// Token: 0x060144B9 RID: 83129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60144B9")]
		[Address(RVA = "0xC842B0", Offset = "0xC82EB0", VA = "0x180C842B0")]
		public TNodeBase()
		{
		}

		// Token: 0x04017EE4 RID: 98020
		[Token(Token = "0x4017EE4")]
		[FieldOffset(Offset = "0x30")]
		[Node.InputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.InheritedAny, false)]
		public TNodeBase from;

		// Token: 0x04017EE5 RID: 98021
		[Token(Token = "0x4017EE5")]
		[FieldOffset(Offset = "0x38")]
		[Node.OutputAttribute(Node.ShowBackingValue.Never, Node.ConnectionType.Override, Node.TypeConstraint.Inherited, false)]
		public TNodeBase next;

		// Token: 0x04017EE6 RID: 98022
		[Token(Token = "0x4017EE6")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private ActionNode _action;

		// Token: 0x04017EE7 RID: 98023
		[Token(Token = "0x4017EE7")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		protected TNodeBase.TNodeBaseData _data;

		// Token: 0x020031FE RID: 12798
		[Token(Token = "0x20031FE")]
		public class TNodeBaseData : ObjectExtensions.ICopyable
		{
			// Token: 0x17003003 RID: 12291
			// (get) Token: 0x060144BB RID: 83131 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060144BC RID: 83132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003003")]
			public string ID
			{
				[Token(Token = "0x60144BB")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60144BC")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x17003004 RID: 12292
			// (get) Token: 0x060144BD RID: 83133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003004")]
			public Dictionary<string, TNodePortIDPair> portIDPairDict
			{
				[Token(Token = "0x60144BD")]
				[Address(RVA = "0xC971A0", Offset = "0xC95DA0", VA = "0x180C971A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060144BE RID: 83134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144BE")]
			[Address(RVA = "0xC96C60", Offset = "0xC95860", VA = "0x180C96C60", Slot = "5")]
			public virtual void ParseTNode(TNodeBase node)
			{
			}

			// Token: 0x060144BF RID: 83135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144BF")]
			[Address(RVA = "0xC96AB0", Offset = "0xC956B0", VA = "0x180C96AB0", Slot = "6")]
			public virtual void FetchDataRef(TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict, ref List<ActionNode> output)
			{
			}

			// Token: 0x060144C0 RID: 83136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144C0")]
			[Address(RVA = "0xC96D20", Offset = "0xC95920", VA = "0x180C96D20", Slot = "7")]
			public virtual void SerializeTNodeBasic(TNodeBase node)
			{
			}

			// Token: 0x060144C1 RID: 83137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144C1")]
			[Address(RVA = "0xC96C40", Offset = "0xC95840", VA = "0x180C96C40", Slot = "4")]
			public void OnAfterCopy()
			{
			}

			// Token: 0x060144C2 RID: 83138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60144C2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TNodeBaseData()
			{
			}

			// Token: 0x04017EEA RID: 98026
			[Token(Token = "0x4017EEA")]
			[FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			private string _iD;

			// Token: 0x04017EEB RID: 98027
			[Token(Token = "0x4017EEB")]
			[FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			private Vector2 _pos;

			// Token: 0x04017EEC RID: 98028
			[Token(Token = "0x4017EEC")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, TNodePortIDPair> m_portIDPairDict;

			// Token: 0x04017EED RID: 98029
			[Token(Token = "0x4017EED")]
			[FieldOffset(Offset = "0x28")]
			[HideInInspector]
			[SerializeField]
			private TNodePortIDPair[] _portIDPair;
		}
	}
}
