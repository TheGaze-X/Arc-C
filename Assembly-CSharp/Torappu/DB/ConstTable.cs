using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x020016AF RID: 5807
	[Token(Token = "0x20016AF")]
	public class ConstTable<TValue, TSingleton> : SingletonAbstractTable<TSingleton> where TValue : new() where TSingleton : ConstTable<TValue, TSingleton>
	{
		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x00039288 File Offset: 0x00037488
		[Token(Token = "0x17000FA1")]
		public override bool inited
		{
			[Token(Token = "0x60092F6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA2")]
		public static TValue data
		{
			[Token(Token = "0x60092F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA3")]
		public TValue instData
		{
			[Token(Token = "0x60092F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x000392A0 File Offset: 0x000374A0
		[Token(Token = "0x60092F9")]
		public override bool Validate()
		{
			return default(bool);
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x000392B8 File Offset: 0x000374B8
		[Token(Token = "0x60092FA")]
		public override bool Init(Stream stream, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x000392D0 File Offset: 0x000374D0
		[Token(Token = "0x60092FB")]
		public override bool Init(TextAsset rawData, IConverter converter)
		{
			return default(bool);
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092FC")]
		public override AbstractTable.IAsyncLoadRequest InitAsync(IConverter converter)
		{
			return null;
		}

		// Token: 0x060092FD RID: 37629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FD")]
		protected void _InitWithData(TValue data, IConverter converter)
		{
		}

		// Token: 0x060092FE RID: 37630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092FE")]
		protected void _InitDataFailed()
		{
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60092FF")]
		public override string SerializeToString(bool intended)
		{
			return null;
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009300")]
		public override string GetDebugString()
		{
			return null;
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009301")]
		public override Type GetDataType()
		{
			return null;
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009302")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009303")]
		public ConstTable()
		{
		}

		// Token: 0x04008893 RID: 34963
		[Token(Token = "0x4008893")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private bool m_inited;

		// Token: 0x04008894 RID: 34964
		[Token(Token = "0x4008894")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private TValue m_data;

		// Token: 0x04008895 RID: 34965
		[Token(Token = "0x4008895")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isValid;

		// Token: 0x04008896 RID: 34966
		[Token(Token = "0x4008896")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x04008897 RID: 34967
		[Token(Token = "0x4008897")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04008898 RID: 34968
		[Token(Token = "0x4008898")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instData;

		// Token: 0x04008899 RID: 34969
		[Token(Token = "0x4008899")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0400889A RID: 34970
		[Token(Token = "0x400889A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400889B RID: 34971
		[Token(Token = "0x400889B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x0400889C RID: 34972
		[Token(Token = "0x400889C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAsync;

		// Token: 0x0400889D RID: 34973
		[Token(Token = "0x400889D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitWithData;

		// Token: 0x0400889E RID: 34974
		[Token(Token = "0x400889E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitDataFailed;

		// Token: 0x0400889F RID: 34975
		[Token(Token = "0x400889F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SerializeToString;

		// Token: 0x040088A0 RID: 34976
		[Token(Token = "0x40088A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDebugString;

		// Token: 0x040088A1 RID: 34977
		[Token(Token = "0x40088A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataType;

		// Token: 0x040088A2 RID: 34978
		[Token(Token = "0x40088A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040088A3 RID: 34979
		[Token(Token = "0x40088A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
