using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[System.Diagnostics.DebuggerDisplay("Count = {InnerExceptionCount}")]
	[System.Serializable]
	public class AggregateException : System.Exception
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4CA4400", Offset = "0x4CA3000", VA = "0x184CA4400")]
		public AggregateException()
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4CA3BC0", Offset = "0x4CA27C0", VA = "0x184CA3BC0")]
		public AggregateException(System.Collections.Generic.IEnumerable<System.Exception> innerExceptions)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4CA43B0", Offset = "0x4CA2FB0", VA = "0x184CA43B0")]
		public AggregateException(params System.Exception[] innerExceptions)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4CA3D70", Offset = "0x4CA2970", VA = "0x184CA3D70")]
		public AggregateException(string message, System.Collections.Generic.IEnumerable<System.Exception> innerExceptions)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x4CA3CA0", Offset = "0x4CA28A0", VA = "0x184CA3CA0")]
		public AggregateException(string message, params System.Exception[] innerExceptions)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4CA3E30", Offset = "0x4CA2A30", VA = "0x184CA3E30")]
		private AggregateException(string message, System.Collections.Generic.IList<System.Exception> innerExceptions)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4CA40D0", Offset = "0x4CA2CD0", VA = "0x184CA40D0")]
		internal AggregateException(System.Collections.Generic.IEnumerable<System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4CA3CB0", Offset = "0x4CA28B0", VA = "0x184CA3CB0")]
		internal AggregateException(string message, System.Collections.Generic.IEnumerable<System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4CA38F0", Offset = "0x4CA24F0", VA = "0x184CA38F0")]
		private AggregateException(string message, System.Collections.Generic.IList<System.Runtime.ExceptionServices.ExceptionDispatchInfo> innerExceptionInfos)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4CA41B0", Offset = "0x4CA2DB0", VA = "0x184CA41B0")]
		protected AggregateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4CA3570", Offset = "0x4CA2170", VA = "0x184CA3570", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4CA34A0", Offset = "0x4CA20A0", VA = "0x184CA34A0", Slot = "7")]
		public override System.Exception GetBaseException()
		{
			return null;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005B")]
		public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> InnerExceptions
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x4CA3250", Offset = "0x4CA1E50", VA = "0x184CA3250")]
		public System.AggregateException Flatten()
		{
			return null;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005C")]
		public override string Message
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x4CA4530", Offset = "0x4CA3130", VA = "0x184CA4530", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x4CA36B0", Offset = "0x4CA22B0", VA = "0x184CA36B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x90")]
		private System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> m_innerExceptions;
	}
}
