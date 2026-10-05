using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	internal sealed class ObjectHolder
	{
		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x4BA2920", Offset = "0x4BA1520", VA = "0x184BA2920")]
		internal ObjectHolder(long objID)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x4BA29D0", Offset = "0x4BA15D0", VA = "0x184BA29D0")]
		internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, System.Reflection.FieldInfo field, int[] arrayIndex)
		{
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x4BA2D00", Offset = "0x4BA1900", VA = "0x184BA2D00")]
		internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, System.Reflection.FieldInfo field, int[] arrayIndex)
		{
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x4BA23C0", Offset = "0x4BA0FC0", VA = "0x184BA23C0")]
		private void IncrementDescendentFixups(int amount)
		{
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x4BA2360", Offset = "0x4BA0F60", VA = "0x184BA2360")]
		internal void DecrementFixupsRemaining(ObjectManager manager)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x4BA23E0", Offset = "0x4BA0FE0", VA = "0x184BA23E0")]
		internal void RemoveDependency(long id)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x4BA2210", Offset = "0x4BA0E10", VA = "0x184BA2210")]
		internal void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x4BA28C0", Offset = "0x4BA14C0", VA = "0x184BA28C0")]
		private void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x4BA2090", Offset = "0x4BA0C90", VA = "0x184BA2090")]
		internal void AddDependency(long dependentObject)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x4BA26B0", Offset = "0x4BA12B0", VA = "0x184BA26B0")]
		internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, System.Reflection.FieldInfo field, int[] arrayIndex, ObjectManager manager)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x4BA23D0", Offset = "0x4BA0FD0", VA = "0x184BA23D0")]
		internal void MarkForCompletionWhenAvailable()
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x4BA2450", Offset = "0x4BA1050", VA = "0x184BA2450")]
		internal void SetFlags()
		{
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x000132A8 File Offset: 0x000114A8
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		internal bool IsIncompleteObjectReference
		{
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x4BA2F30", Offset = "0x4BA1B30", VA = "0x184BA2F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x4BA2FC0", Offset = "0x4BA1BC0", VA = "0x184BA2FC0")]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x1700042A")]
		internal bool RequiresDelayedFixup
		{
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x4BA2F40", Offset = "0x4BA1B40", VA = "0x184BA2F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x1700042B")]
		internal bool RequiresValueTypeFixup
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x4BA2F70", Offset = "0x4BA1B70", VA = "0x184BA2F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000132F0 File Offset: 0x000114F0
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042C")]
		internal bool ValueTypeFixupPerformed
		{
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x4BA2F90", Offset = "0x4BA1B90", VA = "0x184BA2F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x4BA3010", Offset = "0x4BA1C10", VA = "0x184BA3010")]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x1700042D")]
		internal bool HasISerializable
		{
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x4BA2F10", Offset = "0x4BA1B10", VA = "0x184BA2F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x1700042E")]
		internal bool HasSurrogate
		{
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x4BA2F20", Offset = "0x4BA1B20", VA = "0x184BA2F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x1700042F")]
		internal bool CanSurrogatedObjectValueChange
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x4BA2E50", Offset = "0x4BA1A50", VA = "0x184BA2E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x17000430")]
		internal bool CanObjectValueChange
		{
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x4BA2E30", Offset = "0x4BA1A30", VA = "0x184BA2E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x17000431")]
		internal int DirectlyDependentObjects
		{
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x17000432")]
		internal int TotalDependentObjects
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x4B00F30", Offset = "0x4AFFB30", VA = "0x184B00F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00013398 File Offset: 0x00011598
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000433")]
		internal bool Reachable
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x4BA2FE0", Offset = "0x4BA1BE0", VA = "0x184BA2FE0")]
			set
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x17000434")]
		internal bool TypeLoadExceptionReachable
		{
			[Token(Token = "0x6002008")]
			[Address(RVA = "0x4BA2F80", Offset = "0x4BA1B80", VA = "0x184BA2F80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000435")]
		internal TypeLoadExceptionHolder TypeLoadException
		{
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200A")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000436")]
		internal object ObjectValue
		{
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x4BA24E0", Offset = "0x4BA10E0", VA = "0x184BA24E0")]
		internal void SetObjectValue(object obj, ObjectManager manager)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000437")]
		internal SerializationInfo SerializationInfo
		{
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200E")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000438")]
		internal ISerializationSurrogate Surrogate
		{
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000439")]
		internal LongList DependentObjects
		{
			[Token(Token = "0x6002010")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002011")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x000133C8 File Offset: 0x000115C8
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043A")]
		internal bool RequiresSerInfoFixup
		{
			[Token(Token = "0x6002012")]
			[Address(RVA = "0x4BA2F50", Offset = "0x4BA1B50", VA = "0x184BA2F50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x4BA2FF0", Offset = "0x4BA1BF0", VA = "0x184BA2FF0")]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700043B")]
		internal ValueTypeFixupInfo ValueFixup
		{
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x1700043C")]
		internal bool CompletelyFixed
		{
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x4BA2EE0", Offset = "0x4BA1AE0", VA = "0x184BA2EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x1700043D")]
		internal long ContainerID
		{
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x4BA2F00", Offset = "0x4BA1B00", VA = "0x184BA2F00")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x10")]
		private object m_object;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x18")]
		internal long m_id;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x20")]
		private int m_missingElementsRemaining;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x24")]
		private int m_missingDecendents;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x28")]
		internal SerializationInfo m_serInfo;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x30")]
		internal ISerializationSurrogate m_surrogate;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x38")]
		internal FixupHolderList m_missingElements;

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x40")]
		internal LongList m_dependentObjects;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x48")]
		internal ObjectHolder m_next;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x50")]
		internal int m_flags;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x54")]
		private bool m_markForFixupWhenAvailable;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x58")]
		private ValueTypeFixupInfo m_valueFixup;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x60")]
		private TypeLoadExceptionHolder m_typeLoad;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_reachable;
	}
}
