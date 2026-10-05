using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200287E RID: 10366
	[Token(Token = "0x200287E")]
	[Serializable]
	public class ParamOutput<T> : IParamOutput, IParamBindable
	{
		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06011420 RID: 70688 RVA: 0x0006A548 File Offset: 0x00068748
		[Token(Token = "0x1700261D")]
		public bool toInternalPath
		{
			[Token(Token = "0x6011420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06011421 RID: 70689 RVA: 0x0006A560 File Offset: 0x00068760
		[Token(Token = "0x1700261E")]
		public bool toTemp
		{
			[Token(Token = "0x6011421")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06011422 RID: 70690 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06011423 RID: 70691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006F")]
		private event Func<T> getter
		{
			[Token(Token = "0x6011422")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6011423")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06011424 RID: 70692 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06011425 RID: 70693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000070")]
		private event Action<T> setter
		{
			[Token(Token = "0x6011424")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6011425")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06011426 RID: 70694 RVA: 0x0006A578 File Offset: 0x00068778
		[Token(Token = "0x1700261F")]
		public PropertyPath pathRuntime
		{
			[Token(Token = "0x6011426")]
			get
			{
				return default(PropertyPath);
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06011427 RID: 70695 RVA: 0x0006A590 File Offset: 0x00068790
		// (set) Token: 0x06011428 RID: 70696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002620")]
		public bool variableBind
		{
			[Token(Token = "0x6011427")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011428")]
			private set
			{
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06011429 RID: 70697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002621")]
		public Type paramType
		{
			[Token(Token = "0x6011429")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0601142A RID: 70698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002622")]
		public string bindingPath
		{
			[Token(Token = "0x601142A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0601142B RID: 70699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601142C RID: 70700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002623")]
		public ActionContext context
		{
			[Token(Token = "0x601142B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601142C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601142D RID: 70701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601142D")]
		internal void SetterSetValue(T value)
		{
		}

		// Token: 0x0601142E RID: 70702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601142E")]
		public void ClearBind()
		{
		}

		// Token: 0x0601142F RID: 70703 RVA: 0x0006A5A8 File Offset: 0x000687A8
		[Token(Token = "0x601142F")]
		public bool Bind(ParamVariable variable)
		{
			return default(bool);
		}

		// Token: 0x06011430 RID: 70704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011430")]
		public ParamOutput()
		{
		}

		// Token: 0x040134AF RID: 79023
		[Token(Token = "0x40134AF")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty(DefaultValueHandling = 3)]
		[SerializeField]
		[HideInInspector]
		[DefaultValue(0)]
		public int paramTarget;

		// Token: 0x040134B0 RID: 79024
		[Token(Token = "0x40134B0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public string path;

		// Token: 0x040134B3 RID: 79027
		[Token(Token = "0x40134B3")]
		[FieldOffset(Offset = "0x0")]
		private bool m_variableBind;

		// Token: 0x040134B4 RID: 79028
		[Token(Token = "0x40134B4")]
		[FieldOffset(Offset = "0x0")]
		private PropertyPath? m_pathRuntime;
	}
}
