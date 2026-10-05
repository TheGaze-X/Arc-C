using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	[NativeHeader("Configuration/UnityConfigure.h")]
	[NativeHeader("Runtime/Transform/Transform.h")]
	[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
	[RequiredByNativeCode]
	public class Transform : Component, IEnumerable
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		protected Transform()
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00006408 File Offset: 0x00004608
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025F")]
		public Vector3 position
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x5975850", Offset = "0x5974450", VA = "0x185975850")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x59760E0", Offset = "0x5974CE0", VA = "0x1859760E0")]
			set
			{
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00006420 File Offset: 0x00004620
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		public Vector3 localPosition
		{
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x5975520", Offset = "0x5974120", VA = "0x185975520")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x5975E40", Offset = "0x5974A40", VA = "0x185975E40")]
			set
			{
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x5972880", Offset = "0x5971480", VA = "0x185972880")]
		internal Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			return default(Vector3);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x59741C0", Offset = "0x5972DC0", VA = "0x1859741C0")]
		internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5974270", Offset = "0x5972E70", VA = "0x185974270")]
		[NativeConditional("UNITY_EDITOR")]
		internal void SetLocalEulerHint(Vector3 euler)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00006450 File Offset: 0x00004650
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000261")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x5975160", Offset = "0x5973D60", VA = "0x185975160")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x5975BD0", Offset = "0x59747D0", VA = "0x185975BD0")]
			set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000262")]
		public Vector3 localEulerAngles
		{
			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x59753E0", Offset = "0x5973FE0", VA = "0x1859753E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x5975D40", Offset = "0x5974940", VA = "0x185975D40")]
			set
			{
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00006480 File Offset: 0x00004680
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000263")]
		public Vector3 right
		{
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x59758A0", Offset = "0x59744A0", VA = "0x1859758A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x5976130", Offset = "0x5974D30", VA = "0x185976130")]
			set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00006498 File Offset: 0x00004698
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		public Vector3 up
		{
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x5975A10", Offset = "0x5974610", VA = "0x185975A10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x5976280", Offset = "0x5974E80", VA = "0x185976280")]
			set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000064B0 File Offset: 0x000046B0
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000265")]
		public Vector3 forward
		{
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x5975250", Offset = "0x5973E50", VA = "0x185975250")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x5975C80", Offset = "0x5974880", VA = "0x185975C80")]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000064C8 File Offset: 0x000046C8
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x59759C0", Offset = "0x59745C0", VA = "0x1859759C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x5976230", Offset = "0x5974E30", VA = "0x185976230")]
			set
			{
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000064E0 File Offset: 0x000046E0
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		public Quaternion localRotation
		{
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x59755C0", Offset = "0x59741C0", VA = "0x1859755C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x5975EE0", Offset = "0x5974AE0", VA = "0x185975EE0")]
			set
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000064F8 File Offset: 0x000046F8
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000268")]
		[NativeConditional("UNITY_EDITOR")]
		internal RotationOrder rotationOrder
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x5972A20", Offset = "0x5971620", VA = "0x185972A20")]
			get
			{
				return RotationOrder.OrderXYZ;
			}
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x59744F0", Offset = "0x59730F0", VA = "0x1859744F0")]
			set
			{
			}
		}

		// Token: 0x06000B67 RID: 2919
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x5972A20", Offset = "0x5971620", VA = "0x185972A20")]
		[NativeMethod("GetRotationOrder")]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		internal extern int GetRotationOrderInternal();

		// Token: 0x06000B68 RID: 2920
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x59744F0", Offset = "0x59730F0", VA = "0x1859744F0")]
		[NativeConditional("UNITY_EDITOR")]
		[NativeMethod("SetRotationOrder")]
		[MethodImpl(4096)]
		internal extern void SetRotationOrderInternal(RotationOrder rotationOrder);

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000269")]
		public Vector3 localScale
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x5975660", Offset = "0x5974260", VA = "0x185975660")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x5975F80", Offset = "0x5974B80", VA = "0x185975F80")]
			set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		public Transform parent
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x5972940", Offset = "0x5971540", VA = "0x185972940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x5975FD0", Offset = "0x5974BD0", VA = "0x185975FD0")]
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026B")]
		internal Transform parentInternal
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x5972940", Offset = "0x5971540", VA = "0x185972940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x5974380", Offset = "0x5972F80", VA = "0x185974380")]
			set
			{
			}
		}

		// Token: 0x06000B6F RID: 2927
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x5972940", Offset = "0x5971540", VA = "0x185972940")]
		[MethodImpl(4096)]
		private extern Transform GetParent();

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x5974380", Offset = "0x5972F80", VA = "0x185974380")]
		public void SetParent(Transform p)
		{
		}

		// Token: 0x06000B71 RID: 2929
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x59743D0", Offset = "0x5972FD0", VA = "0x1859743D0")]
		[FreeFunction("SetParent", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetParent(Transform parent, bool worldPositionStays);

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x1700026C")]
		public Matrix4x4 worldToLocalMatrix
		{
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x5975B30", Offset = "0x5974730", VA = "0x185975B30")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x1700026D")]
		public Matrix4x4 localToWorldMatrix
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x5975700", Offset = "0x5974300", VA = "0x185975700")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5974490", Offset = "0x5973090", VA = "0x185974490")]
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5974320", Offset = "0x5972F20", VA = "0x185974320")]
		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
		}

		// Token: 0x06000B76 RID: 2934
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x5972980", Offset = "0x5971580", VA = "0x185972980")]
		[MethodImpl(4096)]
		public extern void GetPositionAndRotation(out Vector3 position, out Quaternion rotation);

		// Token: 0x06000B77 RID: 2935
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x59728E0", Offset = "0x59714E0", VA = "0x1859728E0")]
		[MethodImpl(4096)]
		public extern void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation);

		// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x5974E70", Offset = "0x5973A70", VA = "0x185974E70")]
		public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x5974960", Offset = "0x5973560", VA = "0x185974960")]
		public void Translate(Vector3 translation)
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x5974FE0", Offset = "0x5973BE0", VA = "0x185974FE0")]
		public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5975020", Offset = "0x5973C20", VA = "0x185975020")]
		public void Translate(float x, float y, float z)
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x5974A60", Offset = "0x5973660", VA = "0x185974A60")]
		public void Translate(Vector3 translation, Transform relativeTo)
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x5974C60", Offset = "0x5973860", VA = "0x185974C60")]
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x5973A50", Offset = "0x5972650", VA = "0x185973A50")]
		public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x59737C0", Offset = "0x59723C0", VA = "0x1859737C0")]
		public void Rotate(Vector3 eulers)
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x5974010", Offset = "0x5972C10", VA = "0x185974010")]
		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x5973A10", Offset = "0x5972610", VA = "0x185973A10")]
		public void Rotate(float xAngle, float yAngle, float zAngle)
		{
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x5973420", Offset = "0x5972020", VA = "0x185973420")]
		[NativeMethod("RotateAround")]
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x59738D0", Offset = "0x59724D0", VA = "0x1859738D0")]
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x59737F0", Offset = "0x59723F0", VA = "0x1859737F0")]
		public void Rotate(Vector3 axis, float angle)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x59735A0", Offset = "0x59721A0", VA = "0x1859735A0")]
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x59731B0", Offset = "0x5971DB0", VA = "0x1859731B0")]
		public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x5973020", Offset = "0x5971C20", VA = "0x185973020")]
		public void LookAt(Transform target)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x5973140", Offset = "0x5971D40", VA = "0x185973140")]
		public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x59732C0", Offset = "0x5971EC0", VA = "0x1859732C0")]
		public void LookAt(Vector3 worldPosition)
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x5972B00", Offset = "0x5971700", VA = "0x185972B00")]
		[FreeFunction("Internal_LookAt", HasExplicitThis = true)]
		private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x59745D0", Offset = "0x59731D0", VA = "0x1859745D0")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x5974630", Offset = "0x5973230", VA = "0x185974630")]
		public Vector3 TransformDirection(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x5972BC0", Offset = "0x59717C0", VA = "0x185972BC0")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x5972C20", Offset = "0x5971820", VA = "0x185972C20")]
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x5974900", Offset = "0x5973500", VA = "0x185974900")]
		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x5974870", Offset = "0x5973470", VA = "0x185974870")]
		public Vector3 TransformVector(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x5972EF0", Offset = "0x5971AF0", VA = "0x185972EF0")]
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x5972E60", Offset = "0x5971A60", VA = "0x185972E60")]
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x5974720", Offset = "0x5973320", VA = "0x185974720")]
		public Vector3 TransformPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x5974780", Offset = "0x5973380", VA = "0x185974780")]
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x5972DA0", Offset = "0x59719A0", VA = "0x185972DA0")]
		public Vector3 InverseTransformPoint(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x5972D10", Offset = "0x5971910", VA = "0x185972D10")]
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return default(Vector3);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026E")]
		public Transform root
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x59729E0", Offset = "0x59715E0", VA = "0x1859729E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B98 RID: 2968
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x59729E0", Offset = "0x59715E0", VA = "0x1859729E0")]
		[MethodImpl(4096)]
		private extern Transform GetRoot();

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B99 RID: 2969
		[Token(Token = "0x1700026F")]
		public extern int childCount { [Token(Token = "0x6000B99")] [Address(RVA = "0x5975120", Offset = "0x5973D20", VA = "0x185975120")] [NativeMethod("GetChildrenCount")] [MethodImpl(4096)] get; }

		// Token: 0x06000B9A RID: 2970
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x59725F0", Offset = "0x59711F0", VA = "0x1859725F0")]
		[FreeFunction("DetachChildren", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void DetachChildren();

		// Token: 0x06000B9B RID: 2971
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x5974090", Offset = "0x5972C90", VA = "0x185974090")]
		[MethodImpl(4096)]
		public extern void SetAsFirstSibling();

		// Token: 0x06000B9C RID: 2972
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x59740D0", Offset = "0x5972CD0", VA = "0x1859740D0")]
		[MethodImpl(4096)]
		public extern void SetAsLastSibling();

		// Token: 0x06000B9D RID: 2973
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x5974530", Offset = "0x5973130", VA = "0x185974530")]
		[MethodImpl(4096)]
		public extern void SetSiblingIndex(int index);

		// Token: 0x06000B9E RID: 2974
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x5973360", Offset = "0x5971F60", VA = "0x185973360")]
		[NativeMethod("MoveAfterSiblingInternal")]
		[MethodImpl(4096)]
		internal extern void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty);

		// Token: 0x06000B9F RID: 2975
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x5972A60", Offset = "0x5971660", VA = "0x185972A60")]
		[MethodImpl(4096)]
		public extern int GetSiblingIndex();

		// Token: 0x06000BA0 RID: 2976
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x59726D0", Offset = "0x59712D0", VA = "0x1859726D0")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern Transform FindRelativeTransformWithPath([NotNull("NullExceptionObject")] Transform transform, string path, [DefaultValue("false")] bool isActiveOnly);

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x5972630", Offset = "0x5971230", VA = "0x185972630")]
		public Transform Find(string n)
		{
			return null;
		}

		// Token: 0x06000BA2 RID: 2978
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x5974050", Offset = "0x5972C50", VA = "0x185974050")]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		internal extern void SendTransformChangedScale();

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x17000270")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x59757B0", Offset = "0x59743B0", VA = "0x1859757B0")]
			[NativeMethod("GetWorldScaleLossy")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000BA4 RID: 2980
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x5972F50", Offset = "0x5971B50", VA = "0x185972F50")]
		[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool IsChildOf([NotNull("ArgumentNullException")] Transform parent);

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000BA5 RID: 2981
		// (set) Token: 0x06000BA6 RID: 2982
		[Token(Token = "0x17000271")]
		[NativeProperty("HasChangedDeprecated")]
		public extern bool hasChanged { [Token(Token = "0x6000BA5")] [Address(RVA = "0x5975320", Offset = "0x5973F20", VA = "0x185975320")] [MethodImpl(4096)] get; [Token(Token = "0x6000BA6")] [Address(RVA = "0x5975CF0", Offset = "0x59748F0", VA = "0x185975CF0")] [MethodImpl(4096)] set; }

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x5972630", Offset = "0x5971230", VA = "0x185972630")]
		[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", false)]
		public Transform FindChild(string n)
		{
			return null;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x59727B0", Offset = "0x59713B0", VA = "0x1859727B0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x5973760", Offset = "0x5972360", VA = "0x185973760")]
		[Obsolete("warning use Transform.Rotate instead.")]
		public void RotateAround(Vector3 axis, float angle)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x59734E0", Offset = "0x59720E0", VA = "0x1859734E0")]
		[Obsolete("warning use Transform.Rotate instead.")]
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
		}

		// Token: 0x06000BAB RID: 2987
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x5972770", Offset = "0x5971370", VA = "0x185972770")]
		[FreeFunction("GetChild", HasExplicitThis = true)]
		[NativeThrows]
		[MethodImpl(4096)]
		public extern Transform GetChild(int index);

		// Token: 0x06000BAC RID: 2988
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x5972730", Offset = "0x5971330", VA = "0x185972730")]
		[NativeMethod("GetChildrenCount")]
		[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", false)]
		[MethodImpl(4096)]
		public extern int GetChildCount();

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public int hierarchyCapacity
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x5975360", Offset = "0x5973F60", VA = "0x185975360")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x5975B90", Offset = "0x5974790", VA = "0x185975B90")]
			set
			{
			}
		}

		// Token: 0x06000BAF RID: 2991
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x5975360", Offset = "0x5973F60", VA = "0x185975360")]
		[FreeFunction("GetHierarchyCapacity", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int internal_getHierarchyCapacity();

		// Token: 0x06000BB0 RID: 2992
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x5975B90", Offset = "0x5974790", VA = "0x185975B90")]
		[FreeFunction("SetHierarchyCapacity", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void internal_setHierarchyCapacity(int value);

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x17000273")]
		public int hierarchyCount
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x59753A0", Offset = "0x5973FA0", VA = "0x1859753A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000BB2 RID: 2994
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x59753A0", Offset = "0x5973FA0", VA = "0x1859753A0")]
		[FreeFunction("GetHierarchyCount", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern int internal_getHierarchyCount();

		// Token: 0x06000BB3 RID: 2995
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x5972FE0", Offset = "0x5971BE0", VA = "0x185972FE0")]
		[FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = true)]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		internal extern bool IsNonUniformScaleTransform();

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x000066C0 File Offset: 0x000048C0
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		[NativeConditional("UNITY_EDITOR")]
		internal bool constrainProportionsScale
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x5972FA0", Offset = "0x5971BA0", VA = "0x185972FA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x5974110", Offset = "0x5972D10", VA = "0x185974110")]
			set
			{
			}
		}

		// Token: 0x06000BB6 RID: 2998
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x5974110", Offset = "0x5972D10", VA = "0x185974110")]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		private extern void SetConstrainProportionsScale(bool isLinked);

		// Token: 0x06000BB7 RID: 2999
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x5972FA0", Offset = "0x5971BA0", VA = "0x185972FA0")]
		[NativeConditional("UNITY_EDITOR")]
		[MethodImpl(4096)]
		private extern bool IsConstrainProportionsScale();

		// Token: 0x06000BB8 RID: 3000
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x5975800", Offset = "0x5974400", VA = "0x185975800")]
		[MethodImpl(4096)]
		private extern void get_position_Injected(out Vector3 ret);

		// Token: 0x06000BB9 RID: 3001
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x5976090", Offset = "0x5974C90", VA = "0x185976090")]
		[MethodImpl(4096)]
		private extern void set_position_Injected(ref Vector3 value);

		// Token: 0x06000BBA RID: 3002
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x59754D0", Offset = "0x59740D0", VA = "0x1859754D0")]
		[MethodImpl(4096)]
		private extern void get_localPosition_Injected(out Vector3 ret);

		// Token: 0x06000BBB RID: 3003
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x5975DF0", Offset = "0x59749F0", VA = "0x185975DF0")]
		[MethodImpl(4096)]
		private extern void set_localPosition_Injected(ref Vector3 value);

		// Token: 0x06000BBC RID: 3004
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x5972830", Offset = "0x5971430", VA = "0x185972830")]
		[MethodImpl(4096)]
		private extern void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret);

		// Token: 0x06000BBD RID: 3005
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x5974160", Offset = "0x5972D60", VA = "0x185974160")]
		[MethodImpl(4096)]
		private extern void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order);

		// Token: 0x06000BBE RID: 3006
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x5974220", Offset = "0x5972E20", VA = "0x185974220")]
		[MethodImpl(4096)]
		private extern void SetLocalEulerHint_Injected(ref Vector3 euler);

		// Token: 0x06000BBF RID: 3007
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x5975970", Offset = "0x5974570", VA = "0x185975970")]
		[MethodImpl(4096)]
		private extern void get_rotation_Injected(out Quaternion ret);

		// Token: 0x06000BC0 RID: 3008
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x59761E0", Offset = "0x5974DE0", VA = "0x1859761E0")]
		[MethodImpl(4096)]
		private extern void set_rotation_Injected(ref Quaternion value);

		// Token: 0x06000BC1 RID: 3009
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x5975570", Offset = "0x5974170", VA = "0x185975570")]
		[MethodImpl(4096)]
		private extern void get_localRotation_Injected(out Quaternion ret);

		// Token: 0x06000BC2 RID: 3010
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x5975E90", Offset = "0x5974A90", VA = "0x185975E90")]
		[MethodImpl(4096)]
		private extern void set_localRotation_Injected(ref Quaternion value);

		// Token: 0x06000BC3 RID: 3011
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x5975610", Offset = "0x5974210", VA = "0x185975610")]
		[MethodImpl(4096)]
		private extern void get_localScale_Injected(out Vector3 ret);

		// Token: 0x06000BC4 RID: 3012
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x5975F30", Offset = "0x5974B30", VA = "0x185975F30")]
		[MethodImpl(4096)]
		private extern void set_localScale_Injected(ref Vector3 value);

		// Token: 0x06000BC5 RID: 3013
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x5975AE0", Offset = "0x59746E0", VA = "0x185975AE0")]
		[MethodImpl(4096)]
		private extern void get_worldToLocalMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000BC6 RID: 3014
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x59756B0", Offset = "0x59742B0", VA = "0x1859756B0")]
		[MethodImpl(4096)]
		private extern void get_localToWorldMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000BC7 RID: 3015
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x5974430", Offset = "0x5973030", VA = "0x185974430")]
		[MethodImpl(4096)]
		private extern void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation);

		// Token: 0x06000BC8 RID: 3016
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x59742C0", Offset = "0x5972EC0", VA = "0x1859742C0")]
		[MethodImpl(4096)]
		private extern void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation);

		// Token: 0x06000BC9 RID: 3017
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x59733C0", Offset = "0x5971FC0", VA = "0x1859733C0")]
		[MethodImpl(4096)]
		private extern void RotateAroundInternal_Injected(ref Vector3 axis, float angle);

		// Token: 0x06000BCA RID: 3018
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x5972AA0", Offset = "0x59716A0", VA = "0x185972AA0")]
		[MethodImpl(4096)]
		private extern void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp);

		// Token: 0x06000BCB RID: 3019
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x5974570", Offset = "0x5973170", VA = "0x185974570")]
		[MethodImpl(4096)]
		private extern void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret);

		// Token: 0x06000BCC RID: 3020
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x5972B60", Offset = "0x5971760", VA = "0x185972B60")]
		[MethodImpl(4096)]
		private extern void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret);

		// Token: 0x06000BCD RID: 3021
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x5974810", Offset = "0x5973410", VA = "0x185974810")]
		[MethodImpl(4096)]
		private extern void TransformVector_Injected(ref Vector3 vector, out Vector3 ret);

		// Token: 0x06000BCE RID: 3022
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x5972E00", Offset = "0x5971A00", VA = "0x185972E00")]
		[MethodImpl(4096)]
		private extern void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret);

		// Token: 0x06000BCF RID: 3023
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x59746C0", Offset = "0x59732C0", VA = "0x1859746C0")]
		[MethodImpl(4096)]
		private extern void TransformPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x06000BD0 RID: 3024
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x5972CB0", Offset = "0x59718B0", VA = "0x185972CB0")]
		[MethodImpl(4096)]
		private extern void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x06000BD1 RID: 3025
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x5975760", Offset = "0x5974360", VA = "0x185975760")]
		[MethodImpl(4096)]
		private extern void get_lossyScale_Injected(out Vector3 ret);

		// Token: 0x06000BD2 RID: 3026
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x5973540", Offset = "0x5972140", VA = "0x185973540")]
		[MethodImpl(4096)]
		private extern void RotateAround_Injected(ref Vector3 axis, float angle);

		// Token: 0x06000BD3 RID: 3027
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x5973480", Offset = "0x5972080", VA = "0x185973480")]
		[MethodImpl(4096)]
		private extern void RotateAroundLocal_Injected(ref Vector3 axis, float angle);

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x200014D")]
		private class Enumerator : IEnumerator
		{
			// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x4A5F040", Offset = "0x4A5DC40", VA = "0x184A5F040")]
			internal Enumerator(Transform outer)
			{
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000275")]
			public object Current
			{
				[Token(Token = "0x6000BD5")]
				[Address(RVA = "0x595A7A0", Offset = "0x59593A0", VA = "0x18595A7A0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x000066D8 File Offset: 0x000048D8
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x595A740", Offset = "0x5959340", VA = "0x18595A740", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x04000545 RID: 1349
			[Token(Token = "0x4000545")]
			[FieldOffset(Offset = "0x10")]
			private Transform outer;

			// Token: 0x04000546 RID: 1350
			[Token(Token = "0x4000546")]
			[FieldOffset(Offset = "0x18")]
			private int currentIndex;
		}
	}
}
