/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Jaeger.Thrift
{

  public partial class SpanRef : TBase
  {

    /// <summary>
    /// 
    /// <seealso cref="SpanRefType"/>
    /// </summary>
    public SpanRefType RefType { get; set; }

    public long TraceIdLow { get; set; }

    public long TraceIdHigh { get; set; }

    public long SpanId { get; set; }

    public SpanRef()
    {
    }

    public SpanRef(SpanRefType refType, long traceIdLow, long traceIdHigh, long spanId) : this()
    {
      this.RefType = refType;
      this.TraceIdLow = traceIdLow;
      this.TraceIdHigh = traceIdHigh;
      this.SpanId = spanId;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_refType = false;
        bool isset_traceIdLow = false;
        bool isset_traceIdHigh = false;
        bool isset_spanId = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                RefType = (SpanRefType)await iprot.ReadI32Async(cancellationToken);
                isset_refType = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                TraceIdLow = await iprot.ReadI64Async(cancellationToken);
                isset_traceIdLow = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                TraceIdHigh = await iprot.ReadI64Async(cancellationToken);
                isset_traceIdHigh = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                SpanId = await iprot.ReadI64Async(cancellationToken);
                isset_spanId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_refType)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_traceIdLow)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_traceIdHigh)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_spanId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("SpanRef");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "refType";
        field.Type = TType.I32;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async((int)RefType, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "traceIdLow";
        field.Type = TType.I64;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(TraceIdLow, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "traceIdHigh";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(TraceIdHigh, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "spanId";
        field.Type = TType.I64;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SpanId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("SpanRef(");
      sb.Append(", RefType: ");
      sb.Append(RefType);
      sb.Append(", TraceIdLow: ");
      sb.Append(TraceIdLow);
      sb.Append(", TraceIdHigh: ");
      sb.Append(TraceIdHigh);
      sb.Append(", SpanId: ");
      sb.Append(SpanId);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
