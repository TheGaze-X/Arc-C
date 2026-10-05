using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[AdvancedInspector]
	[Serializable]
	public class ActionBinding : ICopiable
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		[Inspect]
		public GameObject GameObject
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x4E5BE0", Offset = "0x4E47E0", VA = "0x1804E5BE0")]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		[Inspect]
		[Restrict("GetComponents")]
		public Component Component
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x4E5B40", Offset = "0x4E4740", VA = "0x1804E5B40")]
			set
			{
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4E42C0", Offset = "0x4E2EC0", VA = "0x1804E42C0")]
		private IList GetComponents()
		{
			return null;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		[Inspect]
		[Restrict("GetMethods", RestrictDisplay.Toolbox)]
		public MethodInfo Method
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x4E5A90", Offset = "0x4E4690", VA = "0x1804E5A90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x4E5CD0", Offset = "0x4E48D0", VA = "0x1804E5CD0")]
			set
			{
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4E4800", Offset = "0x4E3400", VA = "0x1804E4800")]
		private IList GetMethods()
		{
			return null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4E5220", Offset = "0x4E3E20", VA = "0x1804E5220")]
		private bool IsMethodValid(MethodInfo info)
		{
			return default(bool);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4E4E30", Offset = "0x4E3A30", VA = "0x1804E4E30")]
		private string GetParamNames(string name, ParameterInfo[] param)
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x4E4590", Offset = "0x4E3190", VA = "0x1804E4590")]
		private MethodInfo GetMethodInfo()
		{
			return null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event ActionEventHandler OnInvoke
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x4E59D0", Offset = "0x4E45D0", VA = "0x1804E59D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x4E5AA0", Offset = "0x4E46A0", VA = "0x1804E5AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4E5950", Offset = "0x4E4550", VA = "0x1804E5950")]
		public ActionBinding()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4E57C0", Offset = "0x4E43C0", VA = "0x1804E57C0")]
		public ActionBinding(Type[] types)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4E4F90", Offset = "0x4E3B90", VA = "0x1804E4F90")]
		public void Invoke(params object[] args)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4E53E0", Offset = "0x4E3FE0", VA = "0x1804E53E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4E41A0", Offset = "0x4E2DA0", VA = "0x1804E41A0", Slot = "4")]
		public bool Copiable(object destination)
		{
			return default(bool);
		}

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string[] internalParameters;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject gameObject;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Component component;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string method;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[SerializeField]
		[Collection(0, false)]
		private ActionBinding.BindingParameter[] parameters;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		[AdvancedInspector]
		[Serializable]
		public class BindingParameter : ICopy, ICopiable
		{
			// Token: 0x060001DE RID: 478 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x4E83F0", Offset = "0x4E6FF0", VA = "0x1804E83F0")]
			private IList RestrictBinding()
			{
				return null;
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001DF RID: 479 RVA: 0x000025F8 File Offset: 0x000007F8
			[Token(Token = "0x17000076")]
			private bool CanBeInternal
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000077")]
			public Type Type
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x4E8B20", Offset = "0x4E7720", VA = "0x1804E8B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x4E9310", Offset = "0x4E7F10", VA = "0x1804E9310")]
				set
				{
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000078")]
			[Inspect(-2)]
			public string BoundType
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x4E8A10", Offset = "0x4E7610", VA = "0x1804E8A10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000079")]
			[Inspect("IsStatic")]
			[RuntimeResolve("GetRuntimeType")]
			public object Value
			{
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x4E8BB0", Offset = "0x4E77B0", VA = "0x1804E8BB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x4E9740", Offset = "0x4E8340", VA = "0x1804E9740")]
				set
				{
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007A")]
			[Inspect("IsExternal")]
			public GameObject GameObject
			{
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x4E90D0", Offset = "0x4E7CD0", VA = "0x1804E90D0")]
				set
				{
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007B")]
			[Inspect("IsExternal")]
			[Restrict("GetComponents")]
			public Component Component
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x4E8FD0", Offset = "0x4E7BD0", VA = "0x1804E8FD0")]
				set
				{
				}
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x4E74A0", Offset = "0x4E60A0", VA = "0x1804E74A0")]
			private IList GetComponents()
			{
				return null;
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001EA RID: 490 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007C")]
			[Inspect("IsExternal")]
			[Restrict("GetMethods", RestrictDisplay.Toolbox)]
			public MethodInfo Method
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x4E8B10", Offset = "0x4E7710", VA = "0x1804E8B10")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x4E9240", Offset = "0x4E7E40", VA = "0x1804E9240")]
				set
				{
				}
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x4E7850", Offset = "0x4E6450", VA = "0x1804E7850")]
			private IList GetMethods()
			{
				return null;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x00002610 File Offset: 0x00000810
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x4E7E70", Offset = "0x4E6A70", VA = "0x1804E7E70")]
			private bool IsMethodValid(MethodInfo info)
			{
				return default(bool);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x4E7770", Offset = "0x4E6370", VA = "0x1804E7770")]
			private MethodInfo GetMethodInfo()
			{
				return null;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00002628 File Offset: 0x00000828
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4E8070", Offset = "0x4E6C70", VA = "0x1804E8070")]
			private bool IsStatic()
			{
				return default(bool);
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00002640 File Offset: 0x00000840
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x4E7E60", Offset = "0x4E6A60", VA = "0x1804E7E60")]
			private bool IsExternal()
			{
				return default(bool);
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x4E7D40", Offset = "0x4E6940", VA = "0x1804E7D40")]
			private Type GetRuntimeType()
			{
				return null;
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x4E87C0", Offset = "0x4E73C0", VA = "0x1804E87C0")]
			public BindingParameter()
			{
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x4E8560", Offset = "0x4E7160", VA = "0x1804E8560")]
			public BindingParameter(bool canBeInternal)
			{
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00002658 File Offset: 0x00000858
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x4E8080", Offset = "0x4E6C80", VA = "0x1804E8080")]
			public static bool IsValidType(Type type)
			{
				return default(bool);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x4E7D50", Offset = "0x4E6950", VA = "0x1804E7D50")]
			private object Invoke()
			{
				return null;
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x00002670 File Offset: 0x00000870
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x4E7220", Offset = "0x4E5E20", VA = "0x1804E7220", Slot = "5")]
			public bool Copiable(object destination)
			{
				return default(bool);
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4E72D0", Offset = "0x4E5ED0", VA = "0x1804E72D0", Slot = "4")]
			public object Copy(object destination)
			{
				return null;
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x4E8500", Offset = "0x4E7100", VA = "0x1804E8500", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x10")]
			[Inspect(-1)]
			[Restrict("RestrictBinding")]
			public ActionBinding.BindingParameter.BindingType binding;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x14")]
			private bool canBeInternal;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ActionBinding.BindingParameter.BindingValueType type;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string qualifiedTypeName;

			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private bool boolValue;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private int intValue;

			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float floatValue;

			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private string stringValue;

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Vector2 vector2Value;

			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Vector3 vector3Value;

			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			private Vector4 vector4Value;

			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x64")]
			[SerializeField]
			private Color colorValue;

			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x74")]
			[SerializeField]
			private Rect rectValue;

			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			[FieldOffset(Offset = "0x84")]
			[SerializeField]
			private Bounds boundsValue;

			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			[FieldOffset(Offset = "0xA0")]
			[SerializeField]
			private UnityEngine.Object referenceValue;

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0xA8")]
			[SerializeField]
			private GameObject gameObject;

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			[FieldOffset(Offset = "0xB0")]
			[SerializeField]
			private Component component;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			[FieldOffset(Offset = "0xB8")]
			[SerializeField]
			private string method;

			// Token: 0x0200003F RID: 63
			[Token(Token = "0x200003F")]
			public enum BindingType
			{
				// Token: 0x04000085 RID: 133
				[Token(Token = "0x4000085")]
				Internal,
				// Token: 0x04000086 RID: 134
				[Token(Token = "0x4000086")]
				Static,
				// Token: 0x04000087 RID: 135
				[Token(Token = "0x4000087")]
				External
			}

			// Token: 0x02000040 RID: 64
			[Token(Token = "0x2000040")]
			private enum BindingValueType
			{
				// Token: 0x04000089 RID: 137
				[Token(Token = "0x4000089")]
				None,
				// Token: 0x0400008A RID: 138
				[Token(Token = "0x400008A")]
				Boolean,
				// Token: 0x0400008B RID: 139
				[Token(Token = "0x400008B")]
				Integer,
				// Token: 0x0400008C RID: 140
				[Token(Token = "0x400008C")]
				Float,
				// Token: 0x0400008D RID: 141
				[Token(Token = "0x400008D")]
				String,
				// Token: 0x0400008E RID: 142
				[Token(Token = "0x400008E")]
				Vector2,
				// Token: 0x0400008F RID: 143
				[Token(Token = "0x400008F")]
				Vector3,
				// Token: 0x04000090 RID: 144
				[Token(Token = "0x4000090")]
				Vector4,
				// Token: 0x04000091 RID: 145
				[Token(Token = "0x4000091")]
				Color,
				// Token: 0x04000092 RID: 146
				[Token(Token = "0x4000092")]
				Rect,
				// Token: 0x04000093 RID: 147
				[Token(Token = "0x4000093")]
				Bounds,
				// Token: 0x04000094 RID: 148
				[Token(Token = "0x4000094")]
				Reference
			}
		}
	}
}
