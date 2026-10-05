using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DataBind
{
	// Token: 0x0200148C RID: 5260
	[Token(Token = "0x200148C")]
	public abstract class BindProperty<T> : IBindProperty
	{
		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600799D RID: 31133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E88")]
		public T Value
		{
			[Token(Token = "0x600799C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600799D")]
			set
			{
			}
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600799E")]
		public object GetUntypedValue()
		{
			return null;
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600799F")]
		public T GetValueNotNull()
		{
			return null;
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A0")]
		public void NotifyUpdate()
		{
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A1")]
		public virtual void Update(DataBindSystem system)
		{
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A2")]
		public virtual void LuaDataBinder_AddOrRemove(LuaDataBinder luaDataBinder, bool add)
		{
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A3")]
		private void _TryNotifyUpdate()
		{
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079A4")]
		protected BindProperty()
		{
		}

		// Token: 0x040077CB RID: 30667
		[Token(Token = "0x40077CB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private DataBinder[] _binders;

		// Token: 0x040077CC RID: 30668
		[Token(Token = "0x40077CC")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isDirty;

		// Token: 0x040077CD RID: 30669
		[Token(Token = "0x40077CD")]
		[FieldOffset(Offset = "0x0")]
		private T m_value;
	}
}
