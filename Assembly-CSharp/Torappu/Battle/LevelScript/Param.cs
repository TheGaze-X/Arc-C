using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200287D RID: 10365
	[Token(Token = "0x200287D")]
	[Serializable]
	public class Param<T> : IParam, IParamBindable
	{
		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0601140E RID: 70670 RVA: 0x0006A4B8 File Offset: 0x000686B8
		[Token(Token = "0x17002616")]
		public bool isConst
		{
			[Token(Token = "0x601140E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x0601140F RID: 70671 RVA: 0x0006A4D0 File Offset: 0x000686D0
		[Token(Token = "0x17002617")]
		public bool isFromTemp
		{
			[Token(Token = "0x601140F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06011410 RID: 70672 RVA: 0x0006A4E8 File Offset: 0x000686E8
		[Token(Token = "0x17002618")]
		public bool isFromGetter
		{
			[Token(Token = "0x6011410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06011411 RID: 70673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06011412 RID: 70674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002619")]
		public ActionContext context
		{
			[Token(Token = "0x6011411")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6011412")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06011413 RID: 70675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700261A")]
		public Type paramType
		{
			[Token(Token = "0x6011413")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06011414 RID: 70676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700261B")]
		public string bindingPath
		{
			[Token(Token = "0x6011414")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06011415 RID: 70677 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06011416 RID: 70678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006D")]
		private event Func<T> getter
		{
			[Token(Token = "0x6011415")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6011416")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06011417 RID: 70679 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06011418 RID: 70680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400006E")]
		private event Action<T> setter
		{
			[Token(Token = "0x6011417")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6011418")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06011419 RID: 70681 RVA: 0x0006A500 File Offset: 0x00068700
		// (set) Token: 0x0601141A RID: 70682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700261C")]
		public bool variableBind
		{
			[Token(Token = "0x6011419")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601141A")]
			private set
			{
			}
		}

		// Token: 0x0601141B RID: 70683 RVA: 0x0006A518 File Offset: 0x00068718
		[Token(Token = "0x601141B")]
		public bool TryGetGetterValue(out T result)
		{
			return default(bool);
		}

		// Token: 0x0601141C RID: 70684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601141C")]
		internal void SetterSetValue(T value)
		{
		}

		// Token: 0x0601141D RID: 70685 RVA: 0x0006A530 File Offset: 0x00068730
		[Token(Token = "0x601141D")]
		public bool Bind(ParamVariable variable)
		{
			return default(bool);
		}

		// Token: 0x0601141E RID: 70686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601141E")]
		public void ClearBind()
		{
		}

		// Token: 0x0601141F RID: 70687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601141F")]
		public Param()
		{
		}

		// Token: 0x040134A7 RID: 79015
		[Token(Token = "0x40134A7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		[JsonProperty(DefaultValueHandling = 3)]
		[DefaultValue(0)]
		public int paramSource;

		// Token: 0x040134A8 RID: 79016
		[Token(Token = "0x40134A8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[DefaultValue(null)]
		[HideInInspector]
		[JsonProperty(DefaultValueHandling = 3)]
		public string path;

		// Token: 0x040134A9 RID: 79017
		[Token(Token = "0x40134A9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		[JsonProperty(DefaultValueHandling = 3)]
		[DefaultValue(-1)]
		public int idRef;

		// Token: 0x040134AA RID: 79018
		[Token(Token = "0x40134AA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T constValue;

		// Token: 0x040134AE RID: 79022
		[Token(Token = "0x40134AE")]
		[FieldOffset(Offset = "0x0")]
		private bool m_variableBind;
	}
}
