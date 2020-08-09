/**
 * Autogenerated by Thrift Compiler (0.13.0)
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

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;



public partial class Album : TBase
{
  private string _title;
  private string _coverPath;
  private Date _releaseDate;
  private MusicGender _gender;
  private bool _isSingle;

  public short IdAlbum { get; set; }
  public System.Windows.Media.Imaging.BitmapImage AlbumImage { get; set; }
  public string AlbumYear { get; set; }
    public string Title
  {
    get
    {
      return _title;
    }
    set
    {
      __isset.title = true;
      this._title = value;
    }
  }

  public string CoverPath
  {
    get
    {
      return _coverPath;
    }
    set
    {
      __isset.coverPath = true;
      this._coverPath = value;
    }
  }

  public Date ReleaseDate
  {
    get
    {
      return _releaseDate;
    }
    set
    {
      __isset.releaseDate = true;
      this._releaseDate = value;
    }
  }

  /// <summary>
  /// 
  /// <seealso cref="MusicGender"/>
  /// </summary>
  public MusicGender Gender
  {
    get
    {
      return _gender;
    }
    set
    {
      __isset.gender = true;
      this._gender = value;
    }
  }

  public bool IsSingle
  {
    get
    {
      return _isSingle;
    }
    set
    {
      __isset.isSingle = true;
      this._isSingle = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool title;
    public bool coverPath;
    public bool releaseDate;
    public bool gender;
    public bool isSingle;
  }

  public Album()
  {
  }

  public Album(short idAlbum) : this()
  {
    this.IdAlbum = idAlbum;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_idAlbum = false;
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
            if (field.Type == TType.I16)
            {
              IdAlbum = await iprot.ReadI16Async(cancellationToken);
              isset_idAlbum = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              Title = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.String)
            {
              CoverPath = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.Struct)
            {
              ReleaseDate = new Date();
              await ReleaseDate.ReadAsync(iprot, cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.I32)
            {
              Gender = (MusicGender)await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.Bool)
            {
              IsSingle = await iprot.ReadBoolAsync(cancellationToken);
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
      if (!isset_idAlbum)
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
      var struc = new TStruct("Album");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "idAlbum";
      field.Type = TType.I16;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await oprot.WriteI16Async(IdAlbum, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if (Title != null && __isset.title)
      {
        field.Name = "title";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Title, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (CoverPath != null && __isset.coverPath)
      {
        field.Name = "coverPath";
        field.Type = TType.String;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(CoverPath, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (ReleaseDate != null && __isset.releaseDate)
      {
        field.Name = "releaseDate";
        field.Type = TType.Struct;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await ReleaseDate.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.gender)
      {
        field.Name = "gender";
        field.Type = TType.I32;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async((int)Gender, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.isSingle)
      {
        field.Name = "isSingle";
        field.Type = TType.Bool;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBoolAsync(IsSingle, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override bool Equals(object that)
  {
    var other = that as Album;
    if (other == null) return false;
    if (ReferenceEquals(this, other)) return true;
    return System.Object.Equals(IdAlbum, other.IdAlbum)
      && ((__isset.title == other.__isset.title) && ((!__isset.title) || (System.Object.Equals(Title, other.Title))))
      && ((__isset.coverPath == other.__isset.coverPath) && ((!__isset.coverPath) || (System.Object.Equals(CoverPath, other.CoverPath))))
      && ((__isset.releaseDate == other.__isset.releaseDate) && ((!__isset.releaseDate) || (System.Object.Equals(ReleaseDate, other.ReleaseDate))))
      && ((__isset.gender == other.__isset.gender) && ((!__isset.gender) || (System.Object.Equals(Gender, other.Gender))))
      && ((__isset.isSingle == other.__isset.isSingle) && ((!__isset.isSingle) || (System.Object.Equals(IsSingle, other.IsSingle))));
  }

  public override int GetHashCode() {
    int hashcode = 157;
    unchecked {
      hashcode = (hashcode * 397) + IdAlbum.GetHashCode();
      if(__isset.title)
        hashcode = (hashcode * 397) + Title.GetHashCode();
      if(__isset.coverPath)
        hashcode = (hashcode * 397) + CoverPath.GetHashCode();
      if(__isset.releaseDate)
        hashcode = (hashcode * 397) + ReleaseDate.GetHashCode();
      if(__isset.gender)
        hashcode = (hashcode * 397) + Gender.GetHashCode();
      if(__isset.isSingle)
        hashcode = (hashcode * 397) + IsSingle.GetHashCode();
    }
    return hashcode;
  }

  public override string ToString()
  {
    var sb = new StringBuilder("Album(");
    sb.Append(", IdAlbum: ");
    sb.Append(IdAlbum);
    if (Title != null && __isset.title)
    {
      sb.Append(", Title: ");
      sb.Append(Title);
    }
    if (CoverPath != null && __isset.coverPath)
    {
      sb.Append(", CoverPath: ");
      sb.Append(CoverPath);
    }
    if (ReleaseDate != null && __isset.releaseDate)
    {
      sb.Append(", ReleaseDate: ");
      sb.Append(ReleaseDate== null ? "<null>" : ReleaseDate.ToString());
    }
    if (__isset.gender)
    {
      sb.Append(", Gender: ");
      sb.Append(Gender);
    }
    if (__isset.isSingle)
    {
      sb.Append(", IsSingle: ");
      sb.Append(IsSingle);
    }
    sb.Append(")");
    return sb.ToString();
  }
}

